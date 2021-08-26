using System;
using Core.DamageDealer;
using Core.DirectionStateMachines;
using Core.Humans.Factories.Configs;
using Core.InputProviders.IDirectionInputs.DirectionStateMachines;
using UnityEngine;

namespace Core.Humans
{
    [RequireComponent(typeof(BoxCollider2D), typeof(Rigidbody2D))]
    public abstract class Human : MonoBehaviour
    {
        public int KillPoints { get; private set; }

        protected Action ReadInput;

        private float _movementSpeed;
        private DirectionInputStateMachine _directionInputStateMachine;

        public void Initialize(HumanConfigBase config)
        {
            _movementSpeed = config.MovementSpeed;
            ReadInput += ReadDirectionInput;
            KillPoints = config.KillPoints;
            _directionInputStateMachine = GetStateMachine();
        }

        protected abstract DirectionInputStateMachine GetStateMachine();
        
        protected void Move()
        {
            var direction = _directionInputStateMachine.CurrentDirectionInput.Direction;
            var translation = direction * _movementSpeed * Time.fixedDeltaTime;
            transform.Translate(translation);
        }
        
        private void ReadDirectionInput()
        {
            _directionInputStateMachine.CurrentDirectionInput.Read();
        }

        private void OnCollisionEnter(Collision other)
        {
            foreach (var component in other.gameObject.GetComponents<MonoBehaviour>())
            {
                if (component is IDamageDealer)
                {
                    Die();
                }
            }
        }

        protected abstract void Die();

    }
}