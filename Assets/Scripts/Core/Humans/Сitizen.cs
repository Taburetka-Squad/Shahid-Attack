using System.Collections.Generic;
using Core.InputProviders;

namespace Core.Humans
{
    public class Сitizen : Human
    {
        private void FixedUpdate()
        {
            Move();
        }
        
        protected override DirectionInputStateMachine InitializeStateMachine()
        {
            return new CitizenDirectionInput();
        }
    }
}