using Core.InputProviders.IShootInput;

namespace Core.ShootStateMachines
{
    public interface IShootStateSwitcher
    {
        void SwitchState<T>() where T : IShootInput;
    }
}