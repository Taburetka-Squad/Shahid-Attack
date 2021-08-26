using System.Collections.Generic;
using Core.InputProviders;
using Core.InputProviders.IShootInput;

namespace Core.ShootStateMachines.Realization
{
    public class TerroristShootInput : ShootInputStateMachine
    {
        public TerroristShootInput()
        {
            ShootInputs = new List<IShootInput>()
            {
                new KeyBoardInput()
            };
        }
    }
}