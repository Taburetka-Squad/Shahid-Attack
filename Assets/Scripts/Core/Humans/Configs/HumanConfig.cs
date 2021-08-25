using UnityEngine;

namespace Core.Humans.Configs
{
    [CreateAssetMenu(menuName = "HumanConfigs/HumanConfig", order = 0)]
    public class HumanConfig : ScriptableObject
    {
        public int KillPoints;
    }
}