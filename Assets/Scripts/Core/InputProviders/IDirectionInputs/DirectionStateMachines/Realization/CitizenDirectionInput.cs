using System.Collections.Generic;
using Core.InputProviders.IDirectionInputs.Realization;

namespace Core.InputProviders.IDirectionInputs.DirectionStateMachines.Realization
{
    public class CitizenDirectionInput : DirectionInputStateMachine
    {
        public CitizenDirectionInput()
        {
            DirectionInputs = new List<IDirectionInput>()
            {
                new CitizenPeaceDirectionInput(this),
            };

            SwitchState<CitizenPeaceDirectionInput>();
        }
    }
}