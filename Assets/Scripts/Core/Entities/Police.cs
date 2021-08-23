using Core.Weapons;

namespace Core.Entities
{
    public class Police : Human
    {
        private Weapon _weapon;

        private void Update()
        {
            InputProvider.ReadInput();
        }

        protected override void Move()
        {
            transform.Translate(InputProvider.Direction);
        }

        private void Shoot()
        {
            _weapon.Shoot();
        }
    }
}