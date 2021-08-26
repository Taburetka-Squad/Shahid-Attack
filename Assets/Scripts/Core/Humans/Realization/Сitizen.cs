using Core.DirectionStateMachines;
using Core.Humans.Factories.Configs;
using Core.InputProviders.IDirectionInputs.DirectionStateMachines;
using Core.InputProviders.IDirectionInputs.DirectionStateMachines.Realization.Peaceful;
using UnityEngine;

namespace Core.Humans.Realization
{
    public class Сitizen : Human
    {
        [SerializeField] private HumanConfigBase _configBase;
        [SerializeField] private ArcCollider2D _visualArea;

        protected override DirectionInputStateMachine GetStateMachine()
        {
            return new PeaceCitizenDirectionInput();
        }

        protected override void Die()
        {
            Destroy(gameObject);
        }

        private void Awake()
        {
            Initialize(_configBase);
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