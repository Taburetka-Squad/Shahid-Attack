using Core.Weapons.IFireHandler;
using UnityEngine;

namespace Core.Weapons.Config
{
    public abstract class WeaponConfig : ScriptableObject
    {
        public abstract IShoot Shoot { get; }
    }
}