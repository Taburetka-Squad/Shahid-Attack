using Core.Humans.ArmedHumans.Configs;
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

        public void Initialize(ArmedHumanConfig configBase)
        {
            base.Initialize(configBase);

            ReadInput += ReadShootInput;
            
            ShootInput = configBase.ShootInput;
            ShootInput.NeedAnAttack += OnNeedAnAttack;

            _weapon = new Weapon(configBase.WeaponConfig, FirePoint, gameObject.transform);
        }

        private void ReadShootInput()
        {
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