using Core.ProjectTiles.Weapon.Configs;
using UnityEngine;

namespace Core.ProjectTiles.Weapon
{
    public class WeaponProjectTilesBase
    {
        private ParticleSystem _shootParticles;
        private ParticleSystem _hitParticles;
        
        public WeaponProjectTilesBase(WeaponProjectTilesConfig config)
        {
            _shootParticles = config.ShootParticles;
            _hitParticles = config.HitParticles;
        }

        public void OnShot(Transform transform)
        {
            _shootParticles.transform.position = transform.position;
        }
        
        public void OnBulletBodyAttached(Transform transform)
        {
            _hitParticles.transform.position = transform.position;
        }
    }
}