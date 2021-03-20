using System;
using TMPro;
using UnityEngine;

namespace Danil.Scripts
{
    public class Score : MonoBehaviour
    {
        public int ScoreCount = 0;
        
        [SerializeField] private TimeManager _timeManager;
        [SerializeField] private InputLetters _inputLetters;
        
        private TMP_Text _text;

        private void Start()
        {
            _inputLetters.OnAction += Action;
            _text = GetComponent<TMP_Text>();

            _text.text = 0.ToString();
        }
        
        private void Action(bool right)
        {
            if (right)
            {
                ScoreCount += 10 * _timeManager.ReduceCount;
                _text.text = ScoreCount.ToString();
            }
        }
    }
}