using Core.DirectionStateMachines;
using Core.Humans.Factories.Configs;
using UnityEngine;

namespace Core.Humans
{
    [RequireComponent(typeof(BoxCollider2D), typeof(Rigidbody2D))]
    public abstract class Human : MonoBehaviour
    {
        public int KillPoints { get; private set; }

        private DirectionInputStateMachine _directionInputStateMachine;

        public void Initialize(HumanConfig config)
        {
            KillPoints = config.KillPoints;
            _directionInputStateMachine = GetStateMachine();
        }

        protected abstract DirectionInputStateMachine GetStateMachine();

        protected void ReadInput()
        {
            _directionInputStateMachine.CurrentDirectionInput.Read();
        }

        protected void Move()
        {
            transform.Translate(_directionInputStateMachine.CurrentDirectionInput.Direction);
        }
    }
}