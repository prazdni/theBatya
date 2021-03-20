using UnityEngine;

namespace Danil.Scripts
{
    public class TimeManager : MonoBehaviour
    {
        public int ReduceCount => _reduceCount;
        [SerializeField] private InputLetters _inputLetters;

        [SerializeField] private SpriteChanger _spriteChanger;

        [SerializeField] private float _reduce = 1.0f;
        private int _reduceCount = 1;
        [SerializeField] private float _startTime = 6.0f;
        
        private Timer _timer;

        private float _changeCounter;

        private void Start()
        {
            _timer = new Timer(0, _startTime);
            
            _changeCounter = 0.0f;
            
            //_inputLetters.OnAction += Action;
        }

        private void Update()
        {
            if (_timer.CurrentTime > _timer.TimerMinValue)
            {
                if (_changeCounter >= _timer.TimerMaxValue / _spriteChanger.Sprites.SpriteTypes[_spriteChanger.CurrentSpriteTypeNumber].AllSprites.Count)
                {
                    _changeCounter = 0.0f;
                    _spriteChanger.CurrentSpriteListNumber++;
                    _spriteChanger.ChangeSprite();
                }
                
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    Action(true);
                }
                
                _timer.TimerTick(Time.deltaTime);
                _changeCounter += Time.deltaTime;
            }
            else
            {
                Debug.Log("Death");
            }
        }

        private void Action(bool right)
        {
            if (right)
            {
                if (_spriteChanger.CurrentSpriteTypeNumber == 2)
                {
                    _timer = new Timer(0, _timer.TimerMaxValue - _reduce);
                    _spriteChanger.CurrentSpriteTypeNumber = 0;
                    _spriteChanger.CurrentSpriteListNumber = 0;
                    _changeCounter = 0.0f;
                    _reduceCount++;
                }
                else
                {
                    _timer = new Timer(0, _timer.TimerMaxValue);
                    _spriteChanger.CurrentSpriteTypeNumber++;
                    _spriteChanger.CurrentSpriteListNumber = 0;
                    _changeCounter = 0.0f;
                    _spriteChanger.ChangeSprite();
                }
                
                _inputLetters.OnAnswer(right);
            }
        }
    }
}