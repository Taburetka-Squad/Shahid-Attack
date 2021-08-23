using UnityEngine;

namespace Core.Entities
{
    [RequireComponent(typeof(Rigidbody2D))]
    public abstract class Human : MonoBehaviour
    {
        private Rigidbody2D _rigidbody;

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
        }

        public void Move(Vector2 direction)
        {
            _rigidbody.velocity = direction;
        }
    }
}