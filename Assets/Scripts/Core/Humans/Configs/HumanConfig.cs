using Core.InputProviders;
using UnityEngine;

namespace Core.Humans.Configs
{
    [CreateAssetMenu(menuName = "EntityConfig", order = 0)]
    public class HumanConfig : ScriptableObject
    {
        public IDirectionInput DirectionInput;
    }
}