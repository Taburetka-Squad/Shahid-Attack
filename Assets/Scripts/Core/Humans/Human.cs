using Core.Humans.Configs;
using Core.InputProviders;
using UnityEngine;

namespace Core.Humans
{
    [RequireComponent(typeof(BoxCollider2D), typeof(Rigidbody2D))]
    public abstract class Human : MonoBehaviour
    {
        protected IDirectionInput DirectionInput;

        public void Initialize(HumanConfig humanConfig)
        {
            DirectionInput = humanConfig.DirectionInput;
        }

        protected void Move()
        {
            transform.Translate(DirectionInput.Direction);
        }
    }
}