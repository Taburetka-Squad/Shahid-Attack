using System.Collections.Generic;

namespace Core.InputProviders.IDirectionInputs.DirectionStateMachines.Realization
{
    public class TerroristDirectionInput : DirectionInputStateMachine
    {
        public TerroristDirectionInput()
        {
            DirectionInputs = new List<IDirectionInput>()
            {
                new KeyBoardInput()
            };
            
            SwitchState<KeyBoardInput>();
        }
    }
}