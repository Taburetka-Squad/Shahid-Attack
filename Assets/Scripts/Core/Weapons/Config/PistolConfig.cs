using Core.DamageDealer.Projectiles.Bullets;
using Core.Weapons.IShoots;
using UnityEngine;

namespace Core.Weapons.Config
{
    [CreateAssetMenu(menuName = "WeaponConfig/Pistol", order = 0)]
    public class PistolConfig : WeaponConfig
    {
        public float FireForce;
        
        public Bullet Projectile;

        public override IShoot Shoot => new PistolShoot(FireForce, Projectile);
    }
}