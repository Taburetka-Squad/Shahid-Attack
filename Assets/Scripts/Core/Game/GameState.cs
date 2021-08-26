namespace Core.Game
{
    public abstract class GameState
    {
        public GameDifficultyTimer GameDifficultyTimer { get; private set; }
        
        private IGameStateSwitcher _gameStateSwitcher;

        public GameState(IGameStateSwitcher gameStateSwitcher)
        {
            _gameStateSwitcher = gameStateSwitcher;
            GameDifficultyTimer.TimeEnded += _gameStateSwitcher.SwitchNextState;
            GameDifficultyTimer.Start();
        }
    }
}