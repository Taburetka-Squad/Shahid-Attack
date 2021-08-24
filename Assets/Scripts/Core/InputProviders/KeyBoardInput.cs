using System;
using UnityEngine;

namespace Core.InputProviders
{
    public class KeyBoardInput : IInputProvider
    {
        public event Action NeedAnAttack;
        
        public Vector2 Direction { get; private set; }

        public void ReadInput()
        {
            var horizontalDirection = Input.GetAxis("Horizontal");
            var verticalDirection = Input.GetAxis("Vertical");

            var direction = new Vector2(horizontalDirection, verticalDirection);
            Direction = direction.normalized;

            if (Input.GetKey(KeyCode.Mouse0))
            {
                NeedAnAttack?.Invoke();
            }
        }
    }
}