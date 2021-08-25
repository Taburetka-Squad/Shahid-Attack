using Core.Humans.ArmedHumans.Factories;
using Core.Humans.Factories.Configs;
using UnityEngine;

namespace Core.Humans.Factories
{
    public class HumansFactory : ScriptableObject
    {
        [SerializeField] private HumanConfig _citizen;
        [SerializeField] private ArmedHumansFactory _armedHumansFactory;

        public Human GetHuman(HumanType type)
        {
            var config = GetConfig(type);
            var instance = CreateGameObjectInstance(config.Prefab);
            instance.Initialize(config);
            return instance;
        }

        public Human GetHuman(ArmedHumanType type)
        {
            return _armedHumansFactory.GetArmedHuman(type);
        }

        private Human CreateGameObjectInstance(Human prefab)
        {
            return Instantiate(prefab);
        }

        private HumanConfig GetConfig(HumanType type)
        {
            switch (type)
            {
                case HumanType.Citizen: 
                    return _citizen;
            }

            Debug.Log("Haven't config for this type");
            return _citizen;
        }
    }
}