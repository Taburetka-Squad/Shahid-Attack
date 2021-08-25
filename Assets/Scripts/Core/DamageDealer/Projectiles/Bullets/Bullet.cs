using System;
using Core.DamageDealer.Projectiles;
using UnityEngine;

namespace Core.Projectiles.Bullets
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