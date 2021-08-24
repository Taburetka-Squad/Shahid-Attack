using Core.InputProviders;
using UnityEngine;

namespace Core.Entities
{
    [RequireComponent(typeof(BoxCollider2D),typeof(Rigidbody2D))]
    public abstract class Human : MonoBehaviour
    {
        protected IInputProvider InputProvider = new KeyBoardInput();

        protected abstract void Move();
    }
}