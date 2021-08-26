using System;

namespace Core.Game
{
    public interface IGameStateSwitcher
    {
        event Action StateChanged;
        void SwitchNextState();
    }
}