using System.Collections.Generic;
using System.Linq;
using Core.InputProviders.IShootInput;

namespace Core.ShootStateMachines
{
    public abstract class ShootInputStateMachine
    {
        public IShootInput CurrentShootInput { get; private set; }

        protected List<IShootInput> ShootInputs;

        public void SwitchState<T>() where T : IShootInput
        {
            var state = ShootInputs.FirstOrDefault(s => s is T);
            CurrentShootInput = state;
        }
    }
}