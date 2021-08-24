using System.Threading.Tasks;
using Core.DamageDealer.Projectiles;
using Core.Weapons.Config;
using Core.Weapons.IShoots;
using UnityEngine;

namespace Core.Weapons
{
    public class Weapon
    {
        private Projectile _projectile;
        private Transform _firePoint;
        private Transform _humanRotation;

        private bool _canShoot => !_isOnCoolDown && _ammoInMagazine > 0 && !_isReloading;
        private bool _isOnCoolDown;
        private int _timeBetweenShoots;

        private bool _isReloading;
        private int _reloadingTime;

        private int _maxAmmoInMagazin;
        private int _ammoInMagazine;

        private int _maxAmmo;
        private int _ammoInReserve;

        private IShoot _shoot;

        public Weapon(WeaponConfig weaponConfig, Transform firePoint, Transform humanRotation)
        {
            _shoot = weaponConfig.Shoot;
            _projectile = weaponConfig.Projectile;
            _maxAmmo = weaponConfig.MaxAmmo;

            _timeBetweenShoots = weaponConfig.TimeBetweenShoots;
            _reloadingTime = weaponConfig.ReloadingTime;
            
            _firePoint = firePoint;
            _humanRotation = humanRotation;

            _maxAmmo = weaponConfig.MaxAmmo;
            _maxAmmoInMagazin = weaponConfig.MaxAmmoInMagazin;

            _ammoInReserve = _maxAmmo;
            _ammoInMagazine = _maxAmmoInMagazin;
        }

        public void Shoot()
        {
            if (_canShoot)
            {
                _ammoInMagazine -= 1;
                _shoot.TryShoot(_firePoint, _humanRotation, _projectile);
                CoolDown();
            }
        }

        private async void CoolDown()
        {
            _isOnCoolDown = true;
            await Task.Delay(_timeBetweenShoots * 1000);
            _isOnCoolDown = false;
        }

        private async void TryReload()
        {
            if (_ammoInReserve < _ammoInMagazine) return;
            _isReloading = true;
            await Task.Delay(_reloadingTime * 1000);
            _ammoInMagazine = _maxAmmoInMagazin;
            _ammoInReserve -= _maxAmmoInMagazin;
        }
    }
}