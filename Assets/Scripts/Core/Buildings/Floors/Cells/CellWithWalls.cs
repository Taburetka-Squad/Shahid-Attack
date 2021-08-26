using UnityEngine;

namespace Core.Buildings.Floors.Cells
{
    public class CellWithWalls : Cell
    {
        public Wall LeftWall;
        public Wall UpWall;

        private Wall _wallPrefab;

        public CellWithWalls(Wall wallPrefab)
        {
            _wallPrefab = wallPrefab;
        }
        
        public override void InstantiateSelf(Vector2 position, Quaternion rotation, Transform parent)
        {
            
        }
    }
}