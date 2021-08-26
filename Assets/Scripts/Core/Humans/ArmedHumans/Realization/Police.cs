using Core.DirectionStateMachines;
using Core.InputProviders.IDirectionInputs.DirectionStateMachines;
using Core.InputProviders.IDirectionInputs.DirectionStateMachines.Realization;
using Core.ShootStateMachines;
using Core.ShootStateMachines.Realization;

namespace Core.Humans.ArmedHumans.Realization
{
    public class Police : ArmedHuman
    {
        protected override DirectionInputStateMachine GetStateMachine()
        {
            return new CitizenDirectionInput();
        }

        protected override void Die()
        {
            Destroy(gameObject);
        }

        protected override ShootInputStateMachine GetShootInputStateMachine()
        {
            return new PoliceShootInput();
        }
        
        private void Update()
        {
            ReadInput();
        }
    }
}