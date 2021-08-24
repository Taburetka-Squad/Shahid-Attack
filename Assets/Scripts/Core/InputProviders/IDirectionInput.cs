using UnityEngine;

namespace Core.InputProviders
{
    public interface IDirectionInput
    {
        Vector2 Direction { get; }

        void Read();
    }
}