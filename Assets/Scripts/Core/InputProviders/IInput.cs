using System;
using UnityEngine;

namespace Core.InputProviders
{
    public interface IInput
    {
        event Action NeedAnAttack;
        
        Vector2 Direction { get; }

        void ReadInput();
    }
}