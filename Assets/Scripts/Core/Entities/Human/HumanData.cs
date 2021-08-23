using UnityEngine;

namespace Core.Entities
{
    public class HumanData : ScriptableObject
    {
        public float Speed => _speed;

        [SerializeField] private float _speed;
    }
}