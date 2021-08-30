using Core.DamageDealer.Projectiles;
using Core.Weapons.IShoots;
using UnityEngine;

namespace Core.Weapons.Config
{
    public abstract class WeaponConfig : ScriptableObject
    {
        public abstract IShoot Shoot { get; }

        public int MaxAmmo;
        public int MaxAmmoInMagazin;
        
        public int ReloadingTime;
        public int TimeBetweenShoots;
    }
}