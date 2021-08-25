using Core.InputProviders;

namespace Core.Humans.DirectionStateMachines
{
    public interface IDirectionInputStateSwitcher
    {
        void SwitchState<T>() where T : IDirectionInput;
    }
}