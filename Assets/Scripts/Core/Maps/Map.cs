using UnityEngine;

namespace Core.Maps
{
    [RequireComponent(typeof(EdgeCollider2D))]
    public class Map : MonoBehaviour
    {
        public Vector2 Size => _size;
        [SerializeField] private Vector2 _size;
        private EdgeCollider2D _edgeCollider2D;

        private void Awake()
        {
            _edgeCollider2D = gameObject.GetComponent<EdgeCollider2D>();
            _edgeCollider2D.points = GenerateBoards();
        }

        private Vector2[] GenerateBoards()
        {
            var xSize = Size.x / 2;
            var ySize = Size.y / 2;
            
            var points = new Vector2[5];
            points[0] = new Vector2(-xSize, ySize);
            points[1] = new Vector2(xSize, ySize);
            points[2] = new Vector2(xSize, -ySize);
            points[3] = new Vector2(-xSize, -ySize);
            points[4] = new Vector2(-xSize, ySize);
            return points;
        }
    }
}