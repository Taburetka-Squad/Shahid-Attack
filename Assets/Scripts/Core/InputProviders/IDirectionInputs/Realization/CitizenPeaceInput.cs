using Core.DirectionStateMachines;
using UnityEngine;

namespace Core.InputProviders.IDirectionInputs.Realization
{
    public class CitizenPeaceDirectionInput : IDirectionInput
    {
        public Vector2 Direction { get; private set; }

        private IDirectionInputStateSwitcher _stateSwitcher;

        public CitizenPeaceDirectionInput(IDirectionInputStateSwitcher stateSwitcher)
        {
            _stateSwitcher = stateSwitcher;
        }

        public void Read()
        {
            Direction = new Vector2(Random.Range(-1, 2), Random.Range(-1, 2));
        }
    }
}