using Core.ProjectTiles.Weapon;
using DefaultNamespace;
using UnityEngine;

namespace Core.Weapons
{
    public abstract class Weapon
    {
        protected WeaponProjectTilesBase ProjectTilesBase; 
        protected IDamageDealer DamageDealer;
        protected Transform FirePoint;

        public void Shoot()
        {
            
        }
    }
}