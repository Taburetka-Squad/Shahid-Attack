using Core.DirectionStateMachines;
using Core.DirectionStateMachines.Realization.Peace;
using Core.Humans.Factories.Configs;
using UnityEngine;

namespace Core.Humans.Realization
{
    public class Сitizen : Human
    {
        [SerializeField] private HumanConfigBase _configBase;
       
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
        
        protected override DirectionInputStateMachine GetStateMachine()
        {
            return new CitizenDirectionInput();
        }
    }
}