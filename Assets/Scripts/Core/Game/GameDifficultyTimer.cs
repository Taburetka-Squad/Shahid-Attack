using System;
using System.Threading.Tasks;
using UnityEngine;

namespace Core.Game
{
    [CreateAssetMenu(menuName = "Game/GameState/GameDifficultyTimer")]
    public class GameDifficultyTimer : ScriptableObject
    {
        public event Action TimeEnded;

        [SerializeField] private int _timeBeforeSwitchState;
        
        private int _timePassed;
        private bool _isStoped;

        public async void Start()
        {
            while (_timePassed < _timeBeforeSwitchState && !_isStoped)
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