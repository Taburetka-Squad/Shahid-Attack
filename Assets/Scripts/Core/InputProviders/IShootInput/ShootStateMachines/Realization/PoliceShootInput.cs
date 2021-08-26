using System.Collections.Generic;
using Core.InputProviders.IShootInput;

namespace Core.ShootStateMachines.Realization
{
    public class PoliceShootInput : ShootInputStateMachine
    {
        public PoliceShootInput()
        {
            ShootInputs = new List<IShootInput>()
            {
                
            };
        }
    }
}