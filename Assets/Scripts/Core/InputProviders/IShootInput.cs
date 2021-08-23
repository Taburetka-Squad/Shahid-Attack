using System;

namespace Core.InputProviders
{
    public interface IShootInput : IInput
    {
        event Action NeedAnAttack;
    }
}