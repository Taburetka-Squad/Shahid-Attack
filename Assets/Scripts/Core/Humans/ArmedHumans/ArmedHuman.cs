using Core.Humans.ArmedHumans.Configs;
using Core.ShootStateMachines;
using Core.Weapons;
using UnityEngine;

namespace Core.Humans.ArmedHumans
{
    public abstract class ArmedHuman : Human
    {
        [SerializeField] protected Transform FirePoint;

        private ShootInputStateMachine _shootInputStateMachine;

        private Weapon _weapon;

        public void Initialize(ArmedHumanConfig configBase)
        {
            base.Initialize(configBase);

            ReadInput += ReadShootInput;

            _shootInputStateMachine = GetShootInputStateMachine();
            _shootInputStateMachine.CurrentShootInput.NeedAnAttack += OnNeedAnAttack;

            _weapon = new Weapon(configBase.WeaponConfig, FirePoint, gameObject.transform);
        }

        protected abstract ShootInputStateMachine GetShootInputStateMachine();

        private void ReadShootInput()
        {
            _shootInputStateMachine.CurrentShootInput.Read();
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