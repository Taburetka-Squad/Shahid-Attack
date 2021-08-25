using System.Collections.Generic;
using Core.InputProviders;
using Core.InputProviders.IDirectionInputs;

namespace Core.DirectionStateMachines.Realization.Peace
{
    public class CitizenDirectionInput : DirectionInputStateMachine
    {
        public CitizenDirectionInput()
        {
            DirectionInputs = new List<IDirectionInput>()
            {
                new CitizenPeaceDirectionInput(),
            };

            SwitchState<CitizenPeaceDirectionInput>();
        }
    }
}