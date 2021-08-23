using Core.Input;
using UnityEngine;

namespace Core.Entities.Configs
{
    [CreateAssetMenu(menuName = "EntityConfig", order = 0)]
    public class EntityConfig : ScriptableObject
    {
        public IInput InputProvider;
    }
}