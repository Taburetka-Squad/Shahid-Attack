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
            _wall.points = new Vector2[2]
            {
                new Vector2(0, 0.5f),
                new Vector2(0, -0.5f)
            };
        }

        public void Disable()
        {
            Destroy(this);
        }
    }
}