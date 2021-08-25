using System;
using UnityEngine;

namespace Core.DamageDealer.Projectiles.Bullets
{
    public class Bullet : Projectile
    {
        public event Action<Bullet> BulletBodyAttached;

        private void OnCollisionEnter(Collision other)
        {
            BulletBodyAttached?.Invoke(this);
            Destroy(gameObject);
        }
    }
}