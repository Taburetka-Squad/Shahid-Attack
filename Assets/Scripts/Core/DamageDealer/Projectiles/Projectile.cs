using Core.Weapons;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Core.DamageDealer.Projectiles
{
    [RequireComponent(typeof(Rigidbody2D))]
    public abstract class Projectile : PooledObject, IDamageDealer
    {
        [ShowInInspector] public uint Damage { get; private set; }
    }
}