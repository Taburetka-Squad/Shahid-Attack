using Core.Buildings.Doors;
using Core.Buildings.Ladders;

namespace Core.Buildings.Floors
{
    public class Floor
    {
        private Wall _wallPrefab;
        
        private Door[] _doors;
        private Ladder _ladder;

        public Floor(Wall wallPrefab)
        {
            _wallPrefab = wallPrefab;
        }
    }
}