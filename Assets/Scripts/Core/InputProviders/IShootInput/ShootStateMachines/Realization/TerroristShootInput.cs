using System.Collections.Generic;
using Core.ShootStateMachines;

namespace Core.InputProviders.IShootInput.ShootStateMachines.Realization
{
    public class TerroristShootInput : ShootInputStateMachine
    {
        public TerroristShootInput()
        {
            ShootInputs = new List<IShootInput>()
            {
                new KeyBoardInput()
            };
            
            SwitchState<KeyBoardInput>();
        }
    }
}