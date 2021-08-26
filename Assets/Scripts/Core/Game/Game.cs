using System.Collections.Generic;
using Core.Maps;
using UnityEngine;

namespace Core.Game
{
    public class Game : MonoBehaviour
    {
        [SerializeField]private Map _map;
        
        [SerializeField] private GameState[] _gameStatesArr;
        private Queue<GameState> _gameStates;

        private GameStateMachine _gameStateMachine;

        private void Awake()
        {
            _gameStates = new Queue<GameState>();
            
            foreach (var gameState in _gameStatesArr)
            {
                _gameStates.Enqueue(gameState);
            }

            _gameStateMachine = new GameStateMachine(_gameStates, _map, 10, 3);
            _gameStateMachine.Start();
        }
    }
}