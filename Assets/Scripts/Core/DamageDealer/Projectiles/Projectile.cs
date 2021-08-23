using Sirenix.OdinInspector;
using UnityEngine;

namespace Core.DamageDealer.Projectiles
{
    public abstract class Projectile : MonoBehaviour, IDamageDealer
    {
        [ShowInInspector] public uint Damage { get; protected set; }
    }
}