using Core.InputProviders;
using Core.Weapons;

namespace Core.Humans.ArmedHumans
{
    public class Police : ArmedHuman
    {
        private Weapon _weapon;
        
        protected override IShootInput ShootInput { get; }
        
        private void Update()
        {
            Input.Read();
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