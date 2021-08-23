using Core.Entities.Configs;
using Core.InputProviders;
using UnityEngine;

namespace Core.Entities
{
    [RequireComponent(typeof(BoxCollider2D),typeof(Rigidbody2D))]
    public abstract class Entity : MonoBehaviour
    {
        protected IInputProvider InputProvider = new KeyBoardInput();

        public void Initialize(EntityConfig config)
        {
            InputProvider = config.InputProvider;
        }

        protected abstract void Move();

        protected abstract void Shoot();
    }
}