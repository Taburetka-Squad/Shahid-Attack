namespace Core.Weapons
{
    public class WeaponSlot
    {
        public Weapon CurrentWeapon { get; private set; }
        public bool HasWeapon
            => CurrentWeapon != null;

        public void ChangeWeapon(Weapon weapon)
        {
            CurrentWeapon = weapon;
        }
        public void DropWeapon()
        {
            CurrentWeapon = null;
        }
    }
}