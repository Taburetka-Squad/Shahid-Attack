using Core.DirectionStateMachines;
using Core.DirectionStateMachines.Realization.Peace;

namespace Core.Humans.ArmedHumans.Realization
{
    public class Terrorist : ArmedHuman
    {
        private void Update()
        {
            ReadInput();
        }

        private void FixedUpdate()
        {
            Move();
        }

        protected override DirectionInputStateMachine GetStateMachine()
        {
            return new CitizenDirectionInput();
        }
    }
}