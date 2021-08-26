using Core.Buildings.Doors;
using UnityEngine;
using System.Collections.Generic;
using Core.Buildings.Floors.Cells;
using Core.Buildings.Floors.Ladders;

namespace Core.Buildings.Floors
{
    public class Floor : MonoBehaviour
    {
        [SerializeField] private Wall _wallPrefab;
        [SerializeField] private int _x;
        [SerializeField] private int _y;
        
        private Door[] _doors;
        private Ladder _ladder;

        private Cell[,] _tileMap;
        private const float offset = 0.5f;
        
        public Floor(Wall wallPrefab)
        {
            _wallPrefab = wallPrefab;
        }

        private void Start()
        {
            _tileMap = new Cell[_x, _y];

            Generate();
        }

        public void Generate()
        {
            GetAngularCells();

            GenerateMesh();

            for (int i = 0; i < startPositions.Count; i++)
            {
                Vector2 endPosition = new Vector2(Random.Range(2, _x / 2), Random.Range(2, _y / 2));

                CreateRoom(startPositions[i], endPosition);
            }
        }

        private List<Cell> GetAngularCells()
        {
            
        }
        private void CreateRoom(Vector2 startPosition, Vector2 endPosition)
        {
            int startX = startPosition.x > endPosition.x ? (int)endPosition.x : (int)startPosition.x;
            int startY = startPosition.y > endPosition.y ? (int)endPosition.y : (int)startPosition.y;
            
            int endX = startPosition.x > endPosition.x ? (int)startPosition.x : (int)endPosition.x;
            int endY = startPosition.y > endPosition.y ? (int)startPosition.y : (int)endPosition.y;

            for (int i = startX; i < endX; i++)
            {
                for(int j = startY; j < endY; j++)
                {
                    if(i == startX && j == startY)
                    {
                        continue;
                    }
                    else if(i == startX && j > startY)
                    {
                        _mesh[i, j, 1].Disable();
                    }
                    else if(i > startX && j == startY)
                    {
                        _mesh[i, j, 0].Disable();
                    }
                    else
                    {
                        _mesh[i, j, 0].Disable();
                        _mesh[i, j, 1].Disable();
                    }
                }
            }
        }
        private void GenerateMesh()
        {
            for(int i = 0; i <= _mesh.GetUpperBound(0); i++)
            {
                for(int j = 0; j <= _mesh.GetUpperBound(1); j++)
                {
                    if (i == _mesh.GetUpperBound(0) && j != _mesh.GetUpperBound(1))
                    {
                        _mesh[i, j, 0] = Instantiate(_wallPrefab, new Vector2(i, j + offset), Quaternion.identity, transform);
                    }
                    else if(j == _mesh.GetUpperBound(1) && i != _mesh.GetUpperBound(0))
                    {
                        _mesh[i, j, 0] = Instantiate(_wallPrefab, new Vector2(i + offset, j), Quaternion.Euler(0, 0, 90), transform);
                    }
                    else if (i != _mesh.GetUpperBound(0) && j != _mesh.GetUpperBound(1))
                    {
                        _mesh[i, j, 0] = Instantiate(_wallPrefab, new Vector2(i, j + offset), Quaternion.identity, transform);
                        _mesh[i, j, 1] = Instantiate(_wallPrefab, new Vector2(i + offset, j), Quaternion.Euler(0, 0, 90), transform);
                    }    
                }
            }
        }
    }
}