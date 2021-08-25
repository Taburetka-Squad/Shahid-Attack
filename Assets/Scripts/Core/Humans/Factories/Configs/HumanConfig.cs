using UnityEngine;

namespace Core.Humans.Factories.Configs
{
    [CreateAssetMenu(menuName = "HumanConfigs/HumanConfig", order = 0)]
    public class HumanConfig : ScriptableObject
    {
        public Human Prefab;
        public int KillPoints;
    }
}