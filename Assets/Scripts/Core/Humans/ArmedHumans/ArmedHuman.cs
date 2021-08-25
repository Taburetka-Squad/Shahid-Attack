using Core.Humans.ArmedHumans.Configs;
using Core.InputProviders;
using Core.Weapons;
using UnityEngine;

namespace Core.Humans.ArmedHumans
{
    public abstract class ArmedHuman : Human
    {
        [SerializeField] protected Transform FirePoint;
        protected IShootInput ShootInput;
        private Weapon _weapon;

        public void InitializeInternal(ArmedHumanConfig config)
        {
            Initialize(config);
            ShootInput = config.ShootInput;
            ShootInput.NeedAnAttack += OnNeedAnAttack;
            _weapon = new Weapon(config.WeaponConfig, FirePoint, gameObject.transform);
        }

        private void OnNeedAnAttack()
        {
            Shoot();
        }

        private void Shoot()
        {
            _weapon.Shoot();
        }
    }
}