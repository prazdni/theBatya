using System;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Danil.Scripts
{
    public class EndMessage : MonoBehaviour
    {
        [SerializeField] private Score _score;

        private TMP_Text _text;
        private AudioSource _audioSource;
        
        private void Awake()
        {
            _text = GetComponent<TMP_Text>();
            _audioSource = GetComponent<AudioSource>();
            _text.text = "Ждём пройгрыша";
        }

        public void ShowScore()
        {
            _audioSource.Play();
            _text.text = $"Поздравляем, вы набрали {_score.ScoreCount} очков";
        }
    }
}