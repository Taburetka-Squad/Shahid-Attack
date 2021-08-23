using UnityEngine;

namespace Core.InputProviders
{
    public interface IInput
    {
        Vector2 Direction { get; }

        void Read();
    }
}