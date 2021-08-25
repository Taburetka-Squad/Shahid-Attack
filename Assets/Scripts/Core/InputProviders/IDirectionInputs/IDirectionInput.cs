using UnityEngine;

namespace Core.InputProviders.IDirectionInputs
{
    public interface IDirectionInput
    {
        Vector2 Direction { get; }

        void Read();
    }
}