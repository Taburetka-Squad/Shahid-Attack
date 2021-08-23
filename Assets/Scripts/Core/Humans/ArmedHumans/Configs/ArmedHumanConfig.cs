using Core.Humans.Configs;
using Core.InputProviders;
using Core.Weapons;
using UnityEngine;

namespace Core.Humans.ArmedHumans.Configs
{
    [CreateAssetMenu(fileName = "ArmedHumanConfig", order = 0)]
    public class ArmedHumanConfig : HumanConfig
    {
        public Weapon Weapon;
        
        public override IInput Input => ShootInput;
        public IShootInput ShootInput;
    }
}