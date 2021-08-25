using System.Collections.Generic;
using Core.InputProviders;

namespace Core.Humans.ArmedHumans
{
    public class Terrorist : ArmedHuman
    {
        private void Update()
        {
            DirectionInputStateMachine.CurrentDirectionInput.Read();
            ShootInput.Read();
        }

        private void FixedUpdate()
        {
            Move();
        }

        protected override DirectionInputStateMachine InitializeStateMachine()
        {
            return new CitizenDirectionInput();
        }
    }
}
