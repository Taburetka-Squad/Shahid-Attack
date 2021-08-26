using UnityEngine;

namespace Core.Buildings.Floors.Cells
{
    public abstract class Cell
    {
        public abstract void InstantiateSelf(Vector2 position, Quaternion rotation, Transform parent);
    }
}