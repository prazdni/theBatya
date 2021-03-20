using TMPro;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
[RequireComponent(typeof(TMP_Text))]
public class PasteLetter : MonoBehaviour
{
    public int LetterId;
    public TMP_InputField InputField;
    public AudioClip AudioClip;
    public TMP_Text Text;
    
    private AudioSource _audioSource;

    public void Initialize()
    {
        InputField.onValueChanged.AddListener(OnValueChanged);
        InputField.onEndEdit.AddListener(OnEndEdit);
        
        Text = GetComponent<TMP_Text>();
        
        _audioSource = GetComponent<AudioSource>();
    }

    private void OnValueChanged(string str)
    {
        str = str.Replace(" ", "");
        
        if (str.Length == LetterId + 1)
        {
            Text.text = str[LetterId].ToString();
            _audioSource.clip = AudioClip;
            _audioSource.Play();
        }
        else
        {
            if (str.Length < LetterId + 1)
            {
                Text.text = "";
            }
        }
    }
    
    private void OnEndEdit(string str)
    {
        InputField.text = "";
    }
}
