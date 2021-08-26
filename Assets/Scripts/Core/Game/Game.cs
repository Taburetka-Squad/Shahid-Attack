using System.Collections.Generic;
using Core.Humans.Factories;
using Core.Maps;
using UnityEngine;

namespace Core.Game
{
    public class Game : MonoBehaviour
    {
        [SerializeField] private Queue<GameState> _gameStates;
        
        private GameStateMachine _gameStateMachine;
        private HumansFactory _humansFactory;
        private Map _map;

        private void Awake()
        {
            _gameStateMachine = new GameStateMachine(_gameStates);
            _gameStateMachine.Start();
        }
    }

    
}