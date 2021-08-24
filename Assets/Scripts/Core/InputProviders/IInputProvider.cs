using System;
using UnityEngine;

namespace Core.InputProviders
{
    public interface IInputProvider
    {
        event Action NeedAnAttack;
        
        Vector2 Direction { get; }

        void ReadInput();
    }
}