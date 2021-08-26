using System;
using System.Threading.Tasks;
using UnityEngine;

namespace Core.Game
{
    public class GameDifficultyTimer : ScriptableObject
    {
        public event Action TimeEnded;

        public int TimeBeforeSwitchState { get; private set; }
        
        private int _timePassed;
        private bool _isStoped;

        public async void Start()
        {
            while (_timePassed < TimeBeforeSwitchState && !_isStoped)
            {
                await Task.Delay(1000);
                _timePassed++;
            }

            TimeEnded?.Invoke();
        }

        public void Stop()
        {
            _isStoped = true;
        }
    }
}