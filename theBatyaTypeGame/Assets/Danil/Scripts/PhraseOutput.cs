using System;
using TMPro;
using UnityEngine;

namespace Danil.Scripts
{
    public class PhraseOutput : MonoBehaviour
    {
        private TMP_Text _text;

        [SerializeField] private SpriteChanger _spriteChanger;

        private void Awake()
        {
            _text = GetComponent<TMP_Text>();
        }

        public void ChangePhrase(string phrase)
        {
            _text.text = phrase;
        }
    }
}