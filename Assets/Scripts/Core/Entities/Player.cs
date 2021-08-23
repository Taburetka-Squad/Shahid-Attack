using Core.Weapons;

namespace Core.Entities
{
    public class Player : Entity
    {
        private Weapon _weapon;
        
        private void Update()
        {
            InputProvider.ReadInput();
        }

        private void FixedUpdate()
        {
            Move();
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
