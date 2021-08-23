using Core.DamageDealer.Projectiles;
using Core.Projectiles;
using Core.Weapons.IFireHandler;
using UnityEngine;

namespace Core.Weapons
{
    public class Weapon
    {
        private Projectile _projectile;
        private Transform _firePoint;
        
        private IShoot _shoot;
        
        public void Shoot()
        {
            _shoot.Shoot(_firePoint);
        }
    }
}