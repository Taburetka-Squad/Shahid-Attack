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
        [SerializeField] private int _roomCount;

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
            Generate();
        }

        public void Generate()
        {
            _tileMap = new Cell[_x, _y];

            for (int x = 0; x < _tileMap.GetUpperBound(0); x++)
            {
                for (int y = 0; y < _tileMap.GetUpperBound(1); y++)
                {
                    _tileMap[x, y] = new CellWithWalls(_wallPrefab);
                }
            }

            GenerateLoop();
            VisualizeTileMap();
        }

        private void GenerateLoop()
        {
            for (int i = 0; i < _roomCount; i++)
            {
                var angularCellsPositions = GetAngularCellsPositions();

                CreateRoom(angularCellsPositions.ToArray());
            }
        }

        private List<Vector2> GetAngularCellsPositions()
        {
            for (int x = 0; x < _tileMap.GetUpperBound(0); x++)
            {
                for (int y = 0; y < _tileMap.GetUpperBound(1); y++)
                {
                }
            }
        }

        private void CreateRoom(Vector2[] angularCellsPositions)
        {
            var startPosition = angularCellsPositions[Random.Range(0, angularCellsPositions.Length)];

            var endPosition = RandomRoomSize(angularCellsPositions, startPosition);

            int startX = startPosition.x > endPosition.x ? (int) endPosition.x : (int) startPosition.x;
            int startY = startPosition.y > endPosition.y ? (int) endPosition.y : (int) startPosition.y;

            int endX = startPosition.x > endPosition.x ? (int) startPosition.x : (int) endPosition.x;
            int endY = startPosition.y > endPosition.y ? (int) startPosition.y : (int) endPosition.y;

            for (int x = startX; x < endX; x++)
            {
                for (int y = startY; y < endY; y++)
                {
                    if (x == startX && y == startY)
                    {
                        continue;
                    }

                    if (x == startX && y > startY)
                    {
                        _tileMap[x, y] = new EmptyCell();
                        continue;
                    }

                    if (x > startX && y == startY)
                    {
                        _tileMap[x, y] = new EmptyCell();
                        continue;
                    }

                    _tileMap[x, y] = new EmptyCell();
                    _tileMap[x, y] = new EmptyCell();
                }
            }
        }

        private Vector2 RandomRoomSize(Vector2[] angularPointsPositions, Vector2 startPosition)
        {
            
        }

        private void VisualizeTileMap()
        {
            for (var x = 0; x <= _tileMap.GetUpperBound(0); x++)
            {
                for (var y = 0; y <= _tileMap.GetUpperBound(1); y++)
                {
                    _tileMap[x, y].InstantiateSelf(new Vector2(x, y + offset), Quaternion.identity, transform);
                }
            }
        }
    }
}