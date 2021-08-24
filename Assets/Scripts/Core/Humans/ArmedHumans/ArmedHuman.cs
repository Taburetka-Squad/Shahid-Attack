using Core.Humans.ArmedHumans.Configs;
using Core.InputProviders;
using Core.Weapons;
using UnityEngine;

namespace Core.Humans.ArmedHumans
{
    public abstract class ArmedHuman : Human
    {
        [SerializeField] protected Transform FirePoint;
        protected Weapon Weapon;
        protected IShootInput ShootInput;

        public void Initialize(ArmedHumanConfig config)
        {
            ShootInput = config.ShootInput;
            ShootInput.NeedAnAttack += OnNeedAnAttack;
            Weapon = new Weapon(config.WeaponConfig, FirePoint, gameObject.transform);
        }

        private void OnNeedAnAttack()
        {
            Shoot();
        }

        private void Shoot()
        {
            Weapon.Shoot();
        }
    }
}