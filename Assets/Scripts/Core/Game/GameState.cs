using System.Collections.Generic;
using Core.Humans.Factories;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Core.Game
{
    [CreateAssetMenu(menuName = "Game/GameState", order = 0)]
    public class GameState : ScriptableObject
    {
        [ShowInInspector] public GameDifficultyTimer GameDifficultyTimer { get; private set; }

        [ShowInInspector] public Dictionary<HumanType, int> HumanCount { get; private set; }

        private IGameStateSwitcher _gameStateSwitcher;

        public void Initialize(IGameStateSwitcher gameStateSwitcher)
        {
            _gameStateSwitcher = gameStateSwitcher;
        }

        public void EnterInState()
        {
            GameDifficultyTimer.TimeEnded += _gameStateSwitcher.SwitchNextState;
            GameDifficultyTimer.Start();
        }
    }
}