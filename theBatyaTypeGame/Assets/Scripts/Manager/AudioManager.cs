using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.Audio;

namespace Manager
{
    public class AudioManager : MonoBehaviour
    {
        [SerializeField] private AudioMixer _audioMixer;

        public static AudioManager Instance;

        public bool shouldSound => GetMusicVolume() == 0.0f;

        private void Awake()
        {
            if (Instance == null)
            {
                DontDestroyOnLoad(gameObject);
                Instance = this;
            }
            else
            {
                Destroy(gameObject);
            }
        }

        private void Start()
        {
            AdjustMusicVolume(GetMusicVolume());
        }

        public void AdjustMusicVolume(float volume)
        {
            if (!Mathf.Approximately(PlayerPrefs.GetFloat("Music"), -80.0f))
            {
                _audioMixer.SetFloat("Music", volume);
            }
        }

        public void AdjustMusicVolume()
        {
            if (shouldSound)
            {
                _audioMixer.SetFloat("Music", 0.0f);
                PlayerPrefs.SetFloat("Music", 0.0f);
            }
            else
            {
                PlayerPrefs.SetFloat("Music", -80.0f);
                _audioMixer.SetFloat("Music", -80.0f);
            }
        }

        private float GetMusicVolume()
        {
            return PlayerPrefs.GetFloat("Music");
        }
    }
}