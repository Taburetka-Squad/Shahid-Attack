using Core.Buildings.Doors;
using Core.Buildings.Floors;
using UnityEngine;

namespace Core.Buildings
{
    public class Building : MonoBehaviour
    {
        private Vector2 size;
        
        private Material _roof;
        private Floor[] _floors;
        private Door[] _entranceDoors;
    }
}