using Core.Weapons;

namespace Core.Entities
{
    public class Police : Entity
    {
        private Weapon _weapon;
        
        private void Update()
        {
            InputProvider.ReadInput();
        }

        protected override void Move()
        {
            transform.Translate(InputProvider.NormalizedDirection);
        }

        protected override void Shoot()
        {
            _weapon.Shoot();
        }
    }
}