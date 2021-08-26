using System;
using System.Collections.Generic;
using System.Linq;
using Core.Humans.Factories;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Core.Game
{
    [CreateAssetMenu(menuName = "Game/GameState", order = 0)]
    public class GameState : ScriptableObject
    {
        public Dictionary<HumanType, int> HumanCountInPercent { get; private set; }
        [SerializeField] private HumanTypeIntPair[] _humanCountInPercent;

        [ShowInInspector] public GameDifficultyTimer GameDifficultyTimer { get; private set; }
        [ShowInInspector] public HumansFactory HumansFactory { get; private set; }

        private IGameStateSwitcher _gameStateSwitcher;

        public void Initialize(IGameStateSwitcher gameStateSwitcher)
        {
            HumanCountInPercent = new Dictionary<HumanType, int>();
            foreach (var t in _humanCountInPercent)
            {
                HumanCountInPercent.Add(t.Key, t.Value);
            }

            _gameStateSwitcher = gameStateSwitcher;
            _gameStateSwitcher.StateChanged += OnStateChanged;
        }

        public void EnterInState()
        {
            GameDifficultyTimer.TimeEnded += _gameStateSwitcher.SwitchNextState;
            GameDifficultyTimer.Start();
        }

        private void OnStateChanged()
        {
            GameDifficultyTimer.TimeEnded -= _gameStateSwitcher.SwitchNextState;
            _gameStateSwitcher.StateChanged -= OnStateChanged;
        }

#if UNITY_EDITOR
        private void OnValidate()
        {
            int summ = 0;
            for (int i = 0; i < _humanCountInPercent.Length; i++)
            {
                if (_humanCountInPercent[i].Key == HumanType.Terrorist)
                {
                    _humanCountInPercent[i] = new HumanTypeIntPair(HumanType.Citizen,0);
                    throw new Exception("Нельзя добавить террористов");
                }

                summ += _humanCountInPercent[i].Value;
            }
            
            if (summ != 100)
            {
                throw new Exception("Сумма всех значений должна быть ровна 100");
            }
        }
#endif
    }
}