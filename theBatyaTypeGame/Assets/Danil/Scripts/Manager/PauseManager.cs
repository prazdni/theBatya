using System;
using Manager;
using UnityEngine;
using UnityEngine.SceneManagement;

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
                SetPause();
            }
        }

        public void RemovePause()
        {
            _isEnabled = !_isEnabled;
            _pauseMenu.gameObject.SetActive(_isEnabled);
                
            if (_isEnabled)
            {
                Time.timeScale = 0.0f;
                AudioManager.Instance.AdjustMusicVolume(-10);
            }
            else
            {
                Time.timeScale = 1.0f;
                AudioManager.Instance.AdjustMusicVolume(0);
            }
        }

        private void SetPause()
        {
            _isEnabled = !_isEnabled;
            _pauseMenu.gameObject.SetActive(_isEnabled);
                
            if (_isEnabled)
            {
                Time.timeScale = 0.0f;
                AudioManager.Instance.AdjustMusicVolume(-10);
            }
            else
            {
                Time.timeScale = 1.0f;
                AudioManager.Instance.AdjustMusicVolume(0);
            }
        }

        public void LoadScene(int sceneNumber)
        {
            SceneManager.LoadScene(sceneNumber);
        }
    }
}