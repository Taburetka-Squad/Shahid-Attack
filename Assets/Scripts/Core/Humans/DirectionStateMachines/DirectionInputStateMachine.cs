using System.Collections.Generic;
using System.Linq;
using Core.Humans.DirectionStateMachines;
using Core.InputProviders;

namespace Core.Humans
{
    public abstract class DirectionInputStateMachine : IDirectionInputStateSwitcher
    {
        public IDirectionInput CurrentDirectionInput { get; private set; }

        protected List<IDirectionInput> _directionInputs;

        public void SwitchState<T>() where T : IDirectionInput
        {
           var state = _directionInputs.FirstOrDefault(s => s is T);
           CurrentDirectionInput = state;
        }
    }
}