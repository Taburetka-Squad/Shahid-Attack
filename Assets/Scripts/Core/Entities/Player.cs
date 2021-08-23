using Core.Weapons;

namespace Core.Entities
{
    public class Player : Human
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
            transform.Translate(InputProvider.Direction);
        }

        private void Shoot()
        {
            _weapon.Shoot();
        }
    }
}
