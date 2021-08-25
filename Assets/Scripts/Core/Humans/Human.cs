using Core.Humans.Configs;
using UnityEngine;

namespace Core.Humans
{
    [RequireComponent(typeof(BoxCollider2D), typeof(Rigidbody2D))]
    public abstract class Human : MonoBehaviour
    {
        protected int KillPoints;
        protected DirectionInputStateMachine DirectionInputStateMachine;

        public void Initialize(HumanConfig config)
        {
            KillPoints = config.KillPoints;
            DirectionInputStateMachine = InitializeStateMachine();
        }

        protected abstract DirectionInputStateMachine InitializeStateMachine();

        protected void Move()
        {
            transform.Translate(DirectionInputStateMachine.CurrentDirectionInput.Direction);
        }
    }
}