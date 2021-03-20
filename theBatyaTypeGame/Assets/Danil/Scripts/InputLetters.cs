using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Danil.Scripts
{
    [RequireComponent(typeof(AudioSource))]
    public class InputLetters : MonoBehaviour
    {
        [SerializeField] private AudioClip _audioClipRight;
        [SerializeField] private AudioClip _audioClipWrong;
        
        private AudioSource _audioSource;
        private TMP_InputField _inputField;

        private void Start()
        {
            _inputField = GetComponent<TMP_InputField>();
            
            _inputField.onEndEdit.AddListener(OnEndEdit);
            _inputField.ActivateInputField();
        }
        
        private void OnEndEdit(string str)
        {
            _inputField.text = "";
            _inputField.ActivateInputField();
        }

        public void OnAnswer(bool right)
        {
            //if (right)
            //{
            //    _audioSource.clip = _audioClipRight;
            //    _audioSource.Play();
            //}
            //else
            //{
            //    _audioSource.clip = _audioClipWrong;
            //    _audioSource.Play();
            //}
            
            _inputField.onEndEdit.Invoke("");
        }
    }
}