using Core.Weapons;

namespace Core.Entities
{
    public abstract class ArmedHuman : Human
    {
        public WeaponSlot WeaponSlot { get; private set; }
    }
}