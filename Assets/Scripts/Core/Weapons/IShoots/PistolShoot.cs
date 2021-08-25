using Core.DamageDealer.Projectiles;
using UnityEngine;

namespace Core.Weapons.IShoots
{
    public class PistolShoot : IShoot
    {
        private float _fireForce;
        
        public PistolShoot(float fireForce)
        {
            _fireForce = fireForce;
        }

        public void TryShoot(Transform firePoint, Transform humanRotation, Projectile projectile)
        {
            var projectileInstance = Object.Instantiate(projectile, firePoint.position, humanRotation.rotation);
            var rigidbody2d = projectileInstance.GetComponent<Rigidbody2D>();
            rigidbody2d.AddForce(Vector2.up * _fireForce, ForceMode2D.Impulse);
        }
    }
}