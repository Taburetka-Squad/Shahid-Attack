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
        }
    }
}