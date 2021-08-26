using System.Collections.Generic;
using Core.InputProviders.IDirectionInputs.Realization;

namespace Core.InputProviders.IDirectionInputs.DirectionStateMachines.Realization.Peaceful
{
    public class PeaceCitizenDirectionInput : DirectionInputStateMachine
    {
        public PeaceCitizenDirectionInput()
        {
            DirectionInputs = new List<IDirectionInput>()
            {
                new CitizenPeaceDirectionInput(this),
            };

            SwitchState<CitizenPeaceDirectionInput>();
        }
    }
}