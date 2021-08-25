using Core.DirectionStateMachines;
using Core.DirectionStateMachines.Realization.Peace;
using Core.Humans.Configs;
using UnityEngine;

namespace Core.Humans
{
    public class Сitizen : Human
    {
        [SerializeField] private HumanConfig _config;
       
        private void Awake()
        {
            Initialize(_config);
        }

        private void Update()
        {
            ReadInput();
        }

        private void FixedUpdate()
        {
            Move();
        }
        
        protected override DirectionInputStateMachine GetStateMachine()
        {
            return new CitizenDirectionInput();
        }
    }
}