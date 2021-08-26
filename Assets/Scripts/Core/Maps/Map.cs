using Sirenix.OdinInspector;
using UnityEngine;

namespace Core.Maps
{
    [RequireComponent(typeof(EdgeCollider2D))]
    public class Map : MonoBehaviour
    {
        [ShowInInspector] public Vector2 Size { get; private set; }
        private EdgeCollider2D _edgeCollider2D;

        private void Awake()
        {
            _edgeCollider2D = gameObject.GetComponent<EdgeCollider2D>();
            _edgeCollider2D.points = GenerateBoards();
        }

        private Vector2[] GenerateBoards()
        {
            var points = new Vector2[5];
            points[0] = new Vector2(-Size.x, Size.y);
            points[1] = new Vector2(Size.x, Size.y);
            points[2] = new Vector2(Size.x, -Size.y);
            points[3] = new Vector2(-Size.x, -Size.y);
            points[4] = new Vector2(-Size.x, Size.y);
            return points;
        }
#if UNITY_EDITOR
        private void OnDrawGizmos()
        {
            Gizmos.color = Color.grey;
            Gizmos.DrawCube(transform.position, Size);
        }
#endif
    }
}