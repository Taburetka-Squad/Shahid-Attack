using Core.Humans.Configs;
using Core.InputProviders;
using UnityEngine;

namespace Core.Humans
{
    [RequireComponent(typeof(BoxCollider2D), typeof(Rigidbody2D))]
    public abstract class Human : MonoBehaviour
    {
        protected int KillPoints;
        protected IDirectionInput DirectionInput;

        public void Initialize(HumanConfig config)
        {
            KillPoints = config.KillPoints;
            DirectionInput = config.DirectionInput;
        }

        protected void Move()
        {
            transform.Translate(DirectionInput.Direction);
        }
    }
}