using UnityEngine;

namespace Core.Buildings.Floors.Cells
{
    [RequireComponent(typeof(SpriteRenderer))]
    public abstract class Cell
    {
        public Sprite Sprite;
        
        public abstract void InstantiateSelf(Vector2 position, Quaternion rotation, Transform parent);
    }
}