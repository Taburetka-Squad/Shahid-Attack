using System;
using System.Collections.Generic;
using Core.Humans;
using Core.Humans.ArmedHumans.Realization;
using Core.Humans.Factories;
using Core.Maps;
using UnityEngine;
using Object = UnityEngine.Object;
using Random = UnityEngine.Random;

namespace Core.Game
{
    public class GameStateMachine : IGameStateSwitcher, IDisposable
    {
        public event Action GameEnded;

        public event Action<int> PointsAdded;

        public event Action StateChanged;

        public GameState CurrentGameState { get; private set; }

        private int _maxHumansCount;
        private Human[] _humans;

        private int _maxTerroristCount;
        private int _currentTerroristCount;

        private Map _map;
        private readonly Queue<GameState> _gameStates;

        public GameStateMachine(Queue<GameState> gameStates, Map map, int maxHumansCount, int maxTerroristCount)
        {
            _map = map;
            _gameStates = gameStates;

            _maxHumansCount = maxHumansCount;
            _maxTerroristCount = maxTerroristCount;
            _currentTerroristCount = _maxHumansCount;

            _humans = new Human[_maxHumansCount];
            
            foreach (var gameState in _gameStates)
            {
                gameState.Initialize(this);
            }
        }

        public void Start()
        {
            SwitchNextState();
            SpawnAllHumans();
        }

        private void SpawnAllHumans()
        {
            for (var i = 0; i < _maxTerroristCount; i++)
            {
                SpawnHuman(HumanType.Terrorist, false);
            }

            foreach (var type in CurrentGameState.HumanCountInPercent.Keys)
            {
                for (var i = 0; i < CurrentGameState.HumanCountInPercent[type]; i++)
                {
                    SpawnHuman(type, true);
                }
            }
        }

        private void SpawnHuman(HumanType type, bool respawnOnDie)
        {
            var human = CurrentGameState.HumansFactory.GetHuman(type);
            if (human is Terrorist terrorist)
            {
                terrorist.Died += OnTerroristDied;
            }

            var position = _map.transform.position;
            var size = _map.Size;

            var x = Random.Range(position.x - size.x, position.x + size.x);
            var y = Random.Range(position.x - size.y, position.x + size.y);

            human.transform.position = new Vector2(x, y);

            if (!TryAddHuman(human))
            {
                Object.Destroy(human.gameObject);
            }

            if (respawnOnDie)
            {
                human.HumanDied += OnHumanDied;
            }
        }

        private bool TryAddHuman(Human human)
        {
            for (var i = 0; i < _humans.Length; i++)
            {
                if (_humans[i] == null)
                {
                    _humans[i] = human;
                    return true;
                }
            }
            
            return false;
        }

        private void OnHumanDied(int killPoints, HumanType type)
        {
            PointsAdded?.Invoke(killPoints);
            SpawnHuman(type, true);
        }

        private void OnTerroristDied(Terrorist terrorist)
        {
            _currentTerroristCount--;
            if (_currentTerroristCount <= 0)
            {
                GameEnded?.Invoke();
            }
        }

        public void Stop()
        {
            CurrentGameState.GameDifficultyTimer.Stop();
            Dispose();
        }

        public void SwitchNextState()
        {
            if (_gameStates.Count <= 0) return;
            StateChanged?.Invoke();

            CurrentGameState = _gameStates.Dequeue();

            CurrentGameState.EnterInState();
        }

        public void Dispose()
        {
        }
    }
}