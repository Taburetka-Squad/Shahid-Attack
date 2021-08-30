using Core.DamageDealer.Projectiles;
using UnityEngine;

namespace Core.Weapons.IShoots
{
    public class PistolShoot : IShoot
    {
        private float _fireForce;
        private Projectile _prefab;
        private Pool<Projectile> _pool = new Pool<Projectile>();

        public PistolShoot(float fireForce, Projectile prefab)
        {
            _fireForce = fireForce;
            _prefab = prefab;
        }

        public void TryShoot(Transform firePoint, Transform humanRotation)
        {
            if (!_pool.TryGetInactiveObject(out var projectile))
            {
                projectile = Object.Instantiate(_prefab, firePoint.position, humanRotation.rotation);
                projectile.gameObject.SetActive(false);
                _pool.AddObjectToPool(projectile);
            }

            var transform = projectile.transform;
            transform.position = firePoint.position;
            transform.rotation = humanRotation.rotation;
            
            projectile.gameObject.SetActive(true);
            
            var rigidbody2d = projectile.GetComponent<Rigidbody2D>();
            rigidbody2d.AddForce(Vector2.up * _fireForce, ForceMode2D.Impulse);
        }
    }
}