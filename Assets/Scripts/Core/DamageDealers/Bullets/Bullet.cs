using System;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Core.DamageDealers.Bullets
{
    public abstract class Bullet : MonoBehaviour, IDamageDealer
    {
        public event Action<Bullet> BulletBodyAttached;
        
        [ShowInInspector] public int Damage { get; private set; }

        private void OnCollisionEnter(Collision other)
        {
            BulletBodyAttached?.Invoke(this);
            Destroy(gameObject);
        }
    }
}