using UnityEngine;

using Core.Entities;

namespace Core.Input
{
    public class PlayerInput : MonoBehaviour
    {
        public ArmedHuman Human { get; private set; }

        public void ChangeHuman(ArmedHuman human)
        {
            Human = human;
            // change camera target
        }

        private void FixedUpdate()
        {
            Human.Move(GetMoveDirection());

            if (CanShoot())
                Human.WeaponSlot.CurrentWeapon.Shoot();
        }

        private Vector2 GetMoveDirection()
        {
            var horizontalDirection = UnityEngine.Input.GetAxis("Horizontal");
            var verticalDirection = UnityEngine.Input.GetAxis("Vertical");

            return new Vector2(horizontalDirection, verticalDirection);
        }
        private bool CanShoot()
        {
            return UnityEngine.Input.GetMouseButton(0)
                && Human.WeaponSlot.HasWeapon;
        }
    }
}