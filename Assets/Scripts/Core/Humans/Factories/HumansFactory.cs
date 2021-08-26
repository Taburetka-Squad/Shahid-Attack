using System;
using System.Linq;
using Core.Humans.Factories.Configs;
using UnityEngine;

namespace Core.Humans.Factories
{
    [CreateAssetMenu(menuName = "HumanFactory", order = 0)]
    public class HumansFactory : ScriptableObject
    {
        [SerializeField] private HumanConfigBase[] _configs;

        public Human GetHuman(HumanType type)
        {
            var config = _configs.First(s => s.HumanType == type);
            return config.Spawn();
        }
#if UNITY_EDITOR
        
        private void OnValidate()
        {
            foreach (var config in _configs)
            {
                foreach (var selectedConfig in _configs)
                {
                    if (config == selectedConfig) continue;
                    
                    if (config.HumanType == selectedConfig.HumanType) 
                        throw new Exception("Конфиг такого типа уже есть " + config.HumanType);
                }
            }
        }
#endif
    }
}