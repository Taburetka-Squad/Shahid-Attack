using System.Collections.Generic;
using UnityEngine;

namespace Core.Game
{
    public class Game : MonoBehaviour
    {
        [SerializeField] private Queue<GameState> _gameStates;
        
        private GameStateMachine _gameStateMachine;

        private void Awake()
        {
            _gameStateMachine = new GameStateMachine(_gameStates);
            _gameStateMachine.Start();
        }
    }
}