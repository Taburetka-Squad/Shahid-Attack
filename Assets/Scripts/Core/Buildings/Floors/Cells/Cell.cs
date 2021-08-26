using UnityEngine;

namespace Core.Buildings.Floors.Cells
{
    public class Cell
    {
        public Vector2Int Position;

        public Wall LeftWall;
        public Wall UpWall;

        private Wall _wallPrefab;

        public Cell(Wall wallPrefab)
        {
            _wallPrefab = wallPrefab;
        }
    }
}