using Core.DirectionStateMachines;
using Core.DirectionStateMachines.Realization.Peace;

namespace Core.Humans.ArmedHumans.Realization
{
    public class Police : ArmedHuman
    {
        private void Update()
        {
            ReadInput();
        }
        
        protected override DirectionInputStateMachine GetStateMachine()
        {
            return new CitizenDirectionInput();
        }
    }
}