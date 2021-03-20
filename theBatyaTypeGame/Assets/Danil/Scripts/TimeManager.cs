using System;
using UnityEngine;

namespace Danil.Scripts
{
    public class TimeManager : MonoBehaviour
    {
        [SerializeField] private SpriteChanger _spriteChanger;
        [SerializeField] private InputLetters _inputLetters;
        [SerializeField] private float _reduce = 1.0f;
        [SerializeField] private float _startTime = 6.0f;
        
        private Timer _timer;

        private float _spritesChangeCount;

        private void Start()
        {
            _timer = new Timer(_startTime);
            _inputLetters.OnAction += OnAction;
            _spritesChangeCount = _spriteChanger.GetSpritesCount() / _timer.CurrentTime;
        }

        private void Update()
        {
            _timer.TimerTick(Time.deltaTime);

            if (_spritesChangeCount > (_timer.TimerMaxValue - _timer.CurrentTime) / _spriteChanger.GetSpritesCount())
            {
                Debug.Log("changed");
                _spriteChanger.ChangeSprite();
            }

            //if (_timer.CurrentTime < _timer.TimerMinValue)
            //{
            //    Debug.Log("You lose!");
            //}
        }

        private void OnAction(bool right)
        {
            if (!right)
            {
                _timer.StopTimeCount();
            }
            else
            {
                _timer = new Timer(0, _timer.TimerMaxValue - _reduce);
            }
        }
    }
}