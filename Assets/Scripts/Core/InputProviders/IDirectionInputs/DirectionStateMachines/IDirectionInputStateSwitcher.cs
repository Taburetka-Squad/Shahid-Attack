using Core.InputProviders.IDirectionInputs;

namespace Core.DirectionStateMachines
{
    public interface IDirectionInputStateSwitcher
    {
        void SwitchState<T>() where T : IDirectionInput;
    }
}