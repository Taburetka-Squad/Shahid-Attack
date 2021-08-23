using UnityEngine;

namespace Core.Weapons.IFireHandler
{
    public interface IShoot
    {
        void Shoot(Transform firePoint);
    }
}