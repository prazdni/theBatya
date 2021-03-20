using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
[RequireComponent(typeof(TMP_Text))]
public class PasteLetter : MonoBehaviour
{
    public int LetterId;
    public TMP_InputField _inputField;
    
    private AudioSource _audioSource;
    public AudioClip AudioClip;
    private TMP_Text _text;
    
    private void Start()
    {
        _inputField.onValueChanged.AddListener(OnValueChanged);
        _inputField.onEndEdit.AddListener(OnEndEdit);
        _text = GetComponent<TMP_Text>();
        _audioSource = GetComponent<AudioSource>();
        _audioSource.clip = AudioClip;
    }

    private void OnValueChanged(string str)
    {
        str = str.Replace(" ", "");
        
        if (str.Length == LetterId + 1)
        {
            _text.text = str[LetterId].ToString();
            _audioSource.Play();
        }
        else
        {
            if (str.Length < LetterId + 1)
            {
                _text.text = "";
            }
        }
    }
    
    private void OnEndEdit(string str)
    {
        _inputField.text = "";
    }
}
