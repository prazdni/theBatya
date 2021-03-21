using System;
using Manager;
using UnityEngine;

namespace Danil.Scripts
{
    public class PauseManager : MonoBehaviour
    {
        [SerializeField] private RectTransform _pauseMenu;

        private bool _isEnabled;

        private void Start()
        {
            _isEnabled = false;
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                _isEnabled = !_isEnabled;
                _pauseMenu.gameObject.SetActive(_isEnabled);
                
                if (_isEnabled)
                {
                    AudioManager.Instance.AdjustMusicVolume(-10);
                }
                else
                {
                    AudioManager.Instance.AdjustMusicVolume(0);
                }
            }
        }
    }
}