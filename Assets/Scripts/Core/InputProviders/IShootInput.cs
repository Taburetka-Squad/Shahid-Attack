using System;

namespace Core.InputProviders
{
    public interface IShootInput
    {
        event Action NeedAnAttack;
        
        void Read();
    }
}