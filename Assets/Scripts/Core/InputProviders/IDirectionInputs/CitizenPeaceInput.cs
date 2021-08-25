using UnityEngine;

namespace Core.InputProviders.IDirectionInputs
{
    public class CitizenPeaceDirectionInput : IDirectionInput
    {
        public Vector2 Direction { get; private set; }

        public void Read()
        {
            Direction = new Vector2(Random.Range(-1, 2), Random.Range(-1, 2));
        }
    }
}