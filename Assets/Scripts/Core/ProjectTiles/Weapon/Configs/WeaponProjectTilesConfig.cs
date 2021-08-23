using UnityEngine;

namespace Core.ProjectTiles.Weapon.Configs
{
    [CreateAssetMenu(menuName = "WeaponProjectTilesConfig")]
    public class WeaponProjectTilesConfig : ScriptableObject
    {
        public ParticleSystem ShootParticles;
        public ParticleSystem HitParticles;
    }
}