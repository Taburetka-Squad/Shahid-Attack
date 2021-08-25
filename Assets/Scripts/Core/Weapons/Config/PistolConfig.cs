using Core.Weapons.IShoots;
using UnityEngine;

namespace Core.Weapons.Config
{
    [CreateAssetMenu(menuName = "WeaponConfig/Pistol",order = 0)]
    public class PistolConfig : WeaponConfig
    {
        public float FireForce;
        
        public override IShoot Shoot => new PistolShoot(FireForce);
    }
}