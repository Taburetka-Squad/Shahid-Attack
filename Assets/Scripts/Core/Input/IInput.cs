using System;
using UnityEngine;

namespace Core.Input
{
    public interface IInput
    {
        event Action NeedAnAttack;
        
        Vector2 Direction { get; }

        void ReadInput();
    }
}