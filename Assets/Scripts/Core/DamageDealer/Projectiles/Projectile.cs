using Sirenix.OdinInspector;
using UnityEngine;

namespace Core.DamageDealer.Projectiles
{
    [RequireComponent(typeof(Rigidbody2D))]
    public abstract class Projectile : MonoBehaviour, IDamageDealer
    {
        [ShowInInspector] public uint Damage { get; protected set; }
    }
}