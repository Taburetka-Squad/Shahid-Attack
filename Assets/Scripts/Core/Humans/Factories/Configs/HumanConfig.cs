using UnityEngine;

namespace Core.Humans.Factories.Configs
{
    [CreateAssetMenu(menuName = "HumanBaseConfigs/HumanConfig", order = 0)]
    public class HumanConfig : HumanConfigBase
    {
        public Human Prefab;
        
        public override Human Spawn()
        {
            var human = Instantiate(Prefab);
            human.Initialize(this);
            return human;
        }
    }
}