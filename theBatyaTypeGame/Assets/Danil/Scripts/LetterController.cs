using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Danil.Scripts
{
    public class LetterController : MonoBehaviour
    {
        public List<AudioClip> _audioClips;
        private List<PasteLetter> _pasteLetters;
        
        private void Start()
        {
            _pasteLetters = GetComponentsInChildren<PasteLetter>().ToList();
    
            for (int i = 0; i < _pasteLetters.Count; i++)
            {
                _pasteLetters[i].LetterId = i;
                _pasteLetters[i].AudioClip = _audioClips[Random.Range(0, 3)];
            }
        }
    }
}