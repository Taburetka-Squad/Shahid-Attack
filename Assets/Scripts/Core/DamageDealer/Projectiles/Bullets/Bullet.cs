using System;
using System.Collections;
using UnityEngine;

namespace Core.DamageDealer.Projectiles.Bullets
{
    public class Bullet : Projectile
    {
        public event Action<Bullet> BulletBodyAttached;
        private const int _timeToSetActiveFalse = 3;

        private void OnEnable()
        {
            StartCoroutine(DefaultSetActiveFalse());
        }

        private IEnumerator DefaultSetActiveFalse()
        {
            yield return new WaitForSeconds(_timeToSetActiveFalse);
            gameObject.SetActive(false);
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            BulletBodyAttached?.Invoke(this);
            gameObject.SetActive(false);
        }
    }
}