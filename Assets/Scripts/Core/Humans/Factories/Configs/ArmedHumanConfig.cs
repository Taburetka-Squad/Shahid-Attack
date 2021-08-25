﻿using Core.Humans.Factories.Configs;
using Core.InputProviders.IShootInput;
using Core.Weapons.Config;
using UnityEngine;

namespace Core.Humans.ArmedHumans.Configs
{
    [CreateAssetMenu(menuName = "HumanBaseConfigs/ArmedHumanConfig", order = 0)]
    public class ArmedHumanConfig : HumanConfigBase
    {
        public ArmedHuman Prefab;

        public WeaponConfig WeaponConfig;
        public IShootInput ShootInput;

        public override Human Spawn()
        {
            var human = Instantiate(Prefab);
            human.Initialize(this);
            return human;
        }
    }
}