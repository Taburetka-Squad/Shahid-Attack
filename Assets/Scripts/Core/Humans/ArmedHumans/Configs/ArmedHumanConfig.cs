using Core.Humans.Configs;
using Core.InputProviders;
using Core.Weapons.Config;
using UnityEngine;

namespace Core.Humans.ArmedHumans.Configs
{
    [CreateAssetMenu(fileName = "ArmedHumanConfig", order = 0)]
    public class ArmedHumanConfig : HumanConfig
    {
        public WeaponConfig WeaponConfig;
        public IShootInput ShootInput;
    }
}