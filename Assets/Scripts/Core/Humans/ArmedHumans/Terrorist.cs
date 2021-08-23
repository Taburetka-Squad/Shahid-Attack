using Core.InputProviders;
using Core.Weapons;

namespace Core.Humans.ArmedHumans
{
    public class Terrorist : ArmedHuman
    {
        private Weapon _weapon;
        
        protected override IShootInput ShootInput { get; }

        private void Update()
        {
            Input.ReadInput();
        }

        private void FixedUpdate()
        {
            Move();
        }

        protected override void Move()
        {
            transform.Translate(Input.Direction);
        }

        private void Shoot()
        {
            _weapon.Shoot();
        }
    }
}
