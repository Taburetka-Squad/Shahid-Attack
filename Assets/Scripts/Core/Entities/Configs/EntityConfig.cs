using Core.InputProviders;
using UnityEngine;

namespace Core.Entities.Configs
{
    [CreateAssetMenu(menuName = "EntityConfig", order = 0)]
    public class EntityConfig : ScriptableObject
    {
        public IInputProvider InputProvider;
    }
}