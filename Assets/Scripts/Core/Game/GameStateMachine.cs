using System.Collections.Generic;

namespace Core.Game
{
    public class GameStateMachine : IGameStateSwitcher
    {
        public GameState CurrentGameState { get; private set; }

        protected Queue<GameState> _gameStates;

        public GameStateMachine(Queue<GameState> gameStates)
        {
            _gameStates = gameStates;
            foreach (var gameState in _gameStates)
            {
                gameState.Initialize(this);
            }
        }

        public void Start()
        {
            SwitchNextState();
        }

        public void Stop()
        {
            CurrentGameState.GameDifficultyTimer.Stop();
        }

        public void SwitchNextState()
        {
            if (_gameStates.Count > 0)
                CurrentGameState = _gameStates.Peek();
            CurrentGameState.EnterInState();
        }
    }
}