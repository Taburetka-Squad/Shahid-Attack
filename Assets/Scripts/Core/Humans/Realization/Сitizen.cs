using Core.InputProviders.IDirectionInputs.DirectionStateMachines;
using Core.InputProviders.IDirectionInputs.DirectionStateMachines.Realization;
using UnityEngine;

namespace Core.Humans.Realization
{
    public class Сitizen : Human
    {
        [SerializeField] private ArcCollider2D _visualArea;

        protected override DirectionInputStateMachine GetStateMachine()
        {
            return new CitizenDirectionInput();
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