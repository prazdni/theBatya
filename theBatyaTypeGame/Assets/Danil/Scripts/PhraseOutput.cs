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

        public void ChangePhrase(string additionalPhrase)
        {
            if (_spriteChanger.CurrentSpriteTypeNumber == 0)
            {
                _text.text = AllPhrases.DRINK + additionalPhrase;
            }

            if (_spriteChanger.CurrentSpriteTypeNumber == 1)
            {
                _text.text = AllPhrases.SMOKE + additionalPhrase;
            }
            
            if (_spriteChanger.CurrentSpriteTypeNumber == 2)
            {
                _text.text = AllPhrases.USE + additionalPhrase;
            }
        }
    }
}