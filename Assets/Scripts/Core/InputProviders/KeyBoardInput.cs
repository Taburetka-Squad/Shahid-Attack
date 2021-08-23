﻿using System;
using UnityEngine;

namespace Core.InputProviders
{
    public class KeyBoardInput : IShootInput
    {
        public event Action NeedAnAttack;

        public Vector2 Direction { get; private set; }

        public void Read()
        {
            var horizontalDirection = Input.GetAxisRaw("Horizontal");
            var verticalDirection = Input.GetAxisRaw("Vertical");

            Direction = new Vector2(horizontalDirection, verticalDirection);

            if (Input.GetKey(KeyCode.Mouse0))
            {
                NeedAnAttack?.Invoke();
            }
        }
    }
}