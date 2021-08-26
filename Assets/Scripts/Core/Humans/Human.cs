using System;
using Core.DamageDealer;
using Core.DamageDealer.Projectiles;
using Core.Humans.Factories;
using Core.Humans.Factories.Configs;
using Core.InputProviders.IDirectionInputs.DirectionStateMachines;
using UnityEngine;

namespace Core.Humans
{
    [RequireComponent(typeof(BoxCollider2D), typeof(Rigidbody2D))]
    public abstract class Human : MonoBehaviour
    {
        public event Action<int, HumanType> HumanDied;

        protected Action ReadInput;

        private int _killPoints;
        private float _movementSpeed;

        private HumanType HumanType;

        private DirectionInputStateMachine _directionInputStateMachine;

        public void Initialize(HumanConfigBase config)
        {
            HumanType = config.HumanType;
            _movementSpeed = config.MovementSpeed;
            _killPoints = config.KillPoints;

            ReadInput += ReadDirectionInput;
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
                    HumanDied?.Invoke(_killPoints, HumanType);
                    Die();
                }
            }
        }

        protected abstract void Die();
    }
}