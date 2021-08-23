using UnityEngine;

namespace Core.InputProviders
{
    public class KeyBoardInput : IInputProvider
    {
        public Vector2 NormalizedDirection { get; private set; }

        public void ReadInput()
        {
            var horizontalDirection = Input.GetAxis("Horizontal");
            var verticalDirection = Input.GetAxis("Vertical");

            var direction = new Vector2(horizontalDirection, verticalDirection);
            NormalizedDirection = direction.normalized;
        }
    }
}