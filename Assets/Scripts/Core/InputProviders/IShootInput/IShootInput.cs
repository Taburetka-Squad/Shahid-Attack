using System;

namespace Core.InputProviders.IShootInput
{
    public interface IShootInput
    {
        event Action NeedAnAttack;
        
        void Read();
    }
}