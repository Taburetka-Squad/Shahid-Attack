using UnityEngine;

namespace Core.Buildings
{
    [RequireComponent(typeof(EdgeCollider2D))]
    public class Wall : MonoBehaviour
    {
        private EdgeCollider2D _wall;

        private void Awake()
        {
            _wall = gameObject.GetComponent<EdgeCollider2D>();
        }

        public void Disable()
        {
            Destroy(this);
        }
    }
}