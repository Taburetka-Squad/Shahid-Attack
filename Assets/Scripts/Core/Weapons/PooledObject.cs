using System;
using UnityEngine;

namespace Core.Weapons
{
    public class PooledObject : MonoBehaviour
    {
        public event Action<PooledObject> Disabled;

        private void OnDisable()
        {
            Disabled?.Invoke(this);
        }
    }
}