using System;
using UnityEngine;

namespace Core.Buildings.Doors
{
    public class Door : Wall
    {
        private static Quaternion _rotationAngle = Quaternion.Euler(0, 0, 90);

        public event Action<bool> Touched;

        [SerializeField] private Transform _pivot;
        private bool _isOpened;

        [ContextMenu("Open")]
        public void Open()
        {
            if (_isOpened) return;
            _pivot.transform.Rotate(_rotationAngle.eulerAngles);
            _isOpened = true;
            Touched?.Invoke(_isOpened);
        }

        [ContextMenu("Close")]
        public void Close()
        {
            if (!_isOpened) return;
            _pivot.transform.Rotate(_rotationAngle.eulerAngles * -1);
            _isOpened = false;
            Touched?.Invoke(_isOpened);
        }
    }
}