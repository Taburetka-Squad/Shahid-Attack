using Core.Humans.ArmedHumans.Factories.Configs;
using Core.InputProviders.IShootInput;
using Core.Weapons;
using UnityEngine;

namespace Core.Humans.ArmedHumans
{
    public abstract class ArmedHuman : Human
    {
        [SerializeField] protected Transform FirePoint;
        
        protected IShootInput ShootInput;
        
        private Weapon _weapon;

        public void Initialize(ArmedHumanConfig config)
        {
            base.Initialize(config);
            
            ShootInput = config.ShootInput;
            ShootInput.NeedAnAttack += OnNeedAnAttack;

            _weapon = new Weapon(config.WeaponConfig, FirePoint, gameObject.transform);
        }

        protected void ReadInput()
        {
            base.ReadInput();
            ShootInput.Read();
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