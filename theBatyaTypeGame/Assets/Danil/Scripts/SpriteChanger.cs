using System;
using System.Collections.Generic;
using System.Linq;
using Danil.Scripts.Scriptables;
using UnityEngine;

namespace Danil.Scripts
{
    public class SpriteChanger : MonoBehaviour
    {
        [SerializeField] private AllTypesOfSprites _sprites;

        private SpriteRenderer _spriteRenderer;

        private int _currentSpriteTypeNumber = 0;

        private int _currentSpriteListNumber = 0;
        
        private void Start()
        {
            _spriteRenderer = GetComponent<SpriteRenderer>();
            
            _spriteRenderer.sprite = _sprites.SpriteTypes[_currentSpriteTypeNumber].AllSprites[_currentSpriteListNumber];
        }

        public void ChangeSprite()
        {
            _currentSpriteListNumber++;
            
            if (_currentSpriteListNumber >= _sprites.SpriteTypes[_currentSpriteTypeNumber].AllSprites.Count)
            {
                _currentSpriteListNumber = 0;
                _currentSpriteTypeNumber ++;
                
                if (_currentSpriteTypeNumber > _sprites.SpriteTypes.Count)
                {
                    _currentSpriteTypeNumber = 0;
                }
                
                _spriteRenderer.sprite = _sprites.SpriteTypes[_currentSpriteTypeNumber].AllSprites[_currentSpriteListNumber];
            }
        }
        

        public int GetSpritesCount()
        {
            return _currentSpriteListNumber;
        }
    }
}