using Sirenix.OdinInspector;
using UnityEngine;

namespace Core.Humans.Factories.Configs
{
    public abstract class HumanConfigBase : ScriptableObject
    {
        public int KillPoints;
        [ShowInInspector] public HumanType HumanType { get; private set; }

        public abstract Human Spawn();
    }
}