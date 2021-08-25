using System;
using Core.DirectionStateMachines;
using Core.Humans.Factories.Configs;
using UnityEngine;

namespace Core.Humans
{
    [RequireComponent(typeof(BoxCollider2D), typeof(Rigidbody2D))]
    public abstract class Human : MonoBehaviour
    {
        public int KillPoints { get; private set; }

        protected Action ReadInput;

        private DirectionInputStateMachine _directionInputStateMachine;

        public void Initialize(HumanConfigBase configBase)
        {
            ReadInput += ReadDirectionInput;
            KillPoints = configBase.KillPoints;
            _directionInputStateMachine = GetStateMachine();
        }

        protected abstract DirectionInputStateMachine GetStateMachine();
        
        protected void Move()
        {
            transform.Translate(_directionInputStateMachine.CurrentDirectionInput.Direction);
        }
        
        private void ReadDirectionInput()
        {
            _directionInputStateMachine.CurrentDirectionInput.Read();
        }
    }
}