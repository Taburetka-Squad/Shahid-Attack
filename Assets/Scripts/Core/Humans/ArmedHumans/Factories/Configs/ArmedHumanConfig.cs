using Core.Humans.Factories.Configs;
using Core.InputProviders.IShootInput;
using Core.Weapons.Config;
using UnityEngine;

namespace Core.Humans.ArmedHumans.Factories.Configs
{
    [CreateAssetMenu(menuName = "HumanConfigs/ArmedHumanConfig", order = 0)]
    public class ArmedHumanConfig : HumanConfig
    {
        public ArmedHuman Prefab;
        
        public WeaponConfig WeaponConfig;
        public IShootInput ShootInput;
    }
}