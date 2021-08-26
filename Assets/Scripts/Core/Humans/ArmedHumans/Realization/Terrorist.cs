using Core.DirectionStateMachines;
using Core.InputProviders.IDirectionInputs.DirectionStateMachines;
using Core.InputProviders.IDirectionInputs.DirectionStateMachines.Realization.Peaceful;
using Core.ShootStateMachines;
using Core.ShootStateMachines.Realization;

namespace Core.Humans.ArmedHumans.Realization
{
    public class Terrorist : ArmedHuman
    {
        protected override DirectionInputStateMachine GetStateMachine()
        {
            return new PeaceCitizenDirectionInput();
        }

        protected override ShootInputStateMachine GetShootInputStateMachine()
        {
            return new TerroristShootInput();
        }

        protected override void Die()
        {
            Destroy(gameObject);
        }
        
        private void Update()
        {
            ReadInput();
        }

        private void FixedUpdate()
        {
            Move();
        }
    }
}