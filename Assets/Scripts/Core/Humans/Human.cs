using Core.InputProviders;
using UnityEngine;

namespace Core.Humans
{
    [RequireComponent(typeof(BoxCollider2D), typeof(Rigidbody2D))]
    public abstract class Human : MonoBehaviour
    {
        protected abstract IInput Input { get; }

        protected abstract void Move();
    }
}