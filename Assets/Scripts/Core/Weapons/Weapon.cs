using Core.DamageDealers;
using Core.ProjectTiles.Weapon;
using Core.Weapons.IFireHandler;
using UnityEngine;

namespace Core.Weapons
{
    public class Weapon
    {
        private WeaponProjectTilesBase _projectTilesBase; 
        private Transform _firePoint;
        
        private IDamageDealer _damageDealer;
        private IShoot _shoot;
        
        public void Shoot()
        {
            _shoot.Shoot(_firePoint);
        }
    }
}