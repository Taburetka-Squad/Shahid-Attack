using System.Collections.Generic;
using System.Linq;
using Core.DirectionStateMachines;

namespace Core.InputProviders.IDirectionInputs.DirectionStateMachines
{
    public abstract class DirectionInputStateMachine : IDirectionInputStateSwitcher
    {
        public IDirectionInput CurrentDirectionInput { get; private set; }

        protected List<IDirectionInput> DirectionInputs;

        public void SwitchState<T>() where T : IDirectionInput
        {
           var state = DirectionInputs.FirstOrDefault(s => s is T);
           CurrentDirectionInput = state;
        }
    }
}