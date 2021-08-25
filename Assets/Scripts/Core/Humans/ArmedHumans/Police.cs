using System.Collections.Generic;
using Core.InputProviders;

namespace Core.Humans.ArmedHumans
{
    public class Police : ArmedHuman
    {
        private void Update()
        {
            DirectionInputStateMachine.CurrentDirectionInput.Read();
            ShootInput.Read();
        }
        
        protected override DirectionInputStateMachine InitializeStateMachine()
        {
            return new CitizenDirectionInput();
        }
    }
}