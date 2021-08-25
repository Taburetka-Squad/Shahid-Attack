using Core.Humans.ArmedHumans.Factories.Configs;
using UnityEngine;

namespace Core.Humans.ArmedHumans.Factories
{
    public class ArmedHumansFactory : ScriptableObject
    {
        [SerializeField] private ArmedHumanConfig _police, _terrorist;
        
        public ArmedHuman GetArmedHuman(ArmedHumanType type)
        {
            var config = GetConfig(type);
            var instance = CreateGameObjectInstance(config.Prefab);
            instance.Initialize(config);
            return instance;
        }

        private ArmedHuman CreateGameObjectInstance(ArmedHuman prefab)
        {
            return Instantiate(prefab);
        }

        private ArmedHumanConfig GetConfig(ArmedHumanType type)
        {
            switch (type)
            {
                case ArmedHumanType.Police:
                    return _police;
                case ArmedHumanType.Terrorist:
                    return _terrorist;
            }

            Debug.Log("Haven't config for this type");
            return _police;
        }
    }
}