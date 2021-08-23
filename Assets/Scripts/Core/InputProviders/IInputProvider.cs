using UnityEngine;

namespace Core.InputProviders
{
    public interface IInputProvider
    {
        Vector2 NormalizedDirection { get; }

        void ReadInput();
    }
}