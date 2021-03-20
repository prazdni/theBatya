using System;
using System.Collections.Generic;
using System.Linq;
using Danil.Scripts.Scriptables;
using UnityEngine;

namespace Danil.Scripts
{
    public class SpriteChanger : MonoBehaviour
    {
        public AllTypesOfSprites Sprites;

        private SpriteRenderer _spriteRenderer;
        
        public int CurrentSpriteTypeNumber { get; set; }

        public int CurrentSpriteListNumber { get; set; }
        
        private void Start()
        {
            _spriteRenderer = GetComponent<SpriteRenderer>();
            
            _spriteRenderer.sprite = Sprites.SpriteTypes[0].AllSprites[0];
        }

        public void ChangeSprite()
        {
            _spriteRenderer.sprite = Sprites.SpriteTypes[CurrentSpriteTypeNumber].AllSprites[CurrentSpriteListNumber];
        }
    }
}