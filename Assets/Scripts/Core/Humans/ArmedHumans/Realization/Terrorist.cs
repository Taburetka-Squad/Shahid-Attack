using System;
using Core.InputProviders.IDirectionInputs.DirectionStateMachines;
using Core.InputProviders.IDirectionInputs.DirectionStateMachines.Realization;
using Core.InputProviders.IShootInput.ShootStateMachines.Realization;
using Core.ShootStateMachines;

namespace Core.Humans.ArmedHumans.Realization
{
    public class Terrorist : ArmedHuman
    {
        public event Action<Terrorist> Died;
        
        protected override DirectionInputStateMachine GetStateMachine()
        {
            return new TerroristDirectionInput();
        }

        protected override ShootInputStateMachine GetShootInputStateMachine()
        {
            return new TerroristShootInput();
        }

        protected override void Die()
        {
            Died?.Invoke(this);
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