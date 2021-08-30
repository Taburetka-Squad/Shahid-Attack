using UnityEngine;

namespace Core.Weapons.IShoots
{
    public interface IShoot
    {
        void TryShoot(Transform firePoint, Transform humanRotation);
    }
}