using Manager;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SoundButtonWidget : MonoBehaviour
{
    [SerializeField] private TMP_Text _text;
    [SerializeField] private Button _soundButton;

    private void Start()
    {
        _text.text = AudioManager.Instance.shouldSound ? "Выключить звук" : "Включить звук";
        _soundButton.onClick.AddListener(OnSoundButtonClick);
    }

    private void OnDestroy()
    {
        _soundButton.onClick.RemoveListener(OnSoundButtonClick);
    }

    private void OnSoundButtonClick()
    {
        AudioManager.Instance.AdjustMusicVolume();
    }
}