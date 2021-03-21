using System;
using UnityEngine;
using UnityEngine.Audio;

namespace Manager
{
    public class AudioManager : MonoBehaviour
    {
        [SerializeField] private AudioMixer _audioMixer;

        public static AudioManager Instance;

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
            _audioMixer.SetFloat("Music", volume);
        }

        public void AdjustMusicVolume()
        {
            if (GetMusicVolumeBool())
            {
                _audioMixer.SetFloat("Music", -80.0f);
                PlayerPrefs.SetFloat("Music", -80.0f);
            }
            else
            {
                _audioMixer.SetFloat("Music", 0.0f);
                PlayerPrefs.SetFloat("Music", 0.0f);
            }
        }

        public bool GetMusicVolumeBool()
        {
            return Mathf.Approximately(PlayerPrefs.GetFloat("Music"), 0.0f);
        }

        public float GetMusicVolume()
        {
            return PlayerPrefs.GetFloat("Music");
        }
    }
}