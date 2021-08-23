using System;
using DefaultNamespace;
using UnityEngine;

namespace Core.Bullets
{
    public abstract class Bullet : MonoBehaviour, IDamageDealer
    {
        public event Action<Bullet> BulletBodyAttached;

        public int Damage { get; private set; }

        private void OnCollisionEnter(Collision other)
        {
            BulletBodyAttached?.Invoke(this);
            Destroy(gameObject);
        }
    }
}