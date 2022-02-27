using UnityEngine;
using UnityEngine.UI;

namespace Danil.Scripts
{
    public class RulesMenu : MonoBehaviour
    {
        [SerializeField] private GameObject _root;
        [SerializeField] private Button _backButton;

        private void Start()
        {
            OnStateChanged(StateManager.Instance.currentState);

            StateManager.Instance.onStateChanged += OnStateChanged;
            _backButton.onClick.AddListener(OnBackButtonClick);
        }

        private void OnDestroy()
        {
            StateManager.Instance.onStateChanged -= OnStateChanged;
            _backButton.onClick.RemoveListener(OnBackButtonClick);
        }
        
        private void OnStateChanged(State state)
        {
            _root.SetActive(state == State.Rules);
        }

        private void OnBackButtonClick()
        {
            StateManager.Instance.SetState(State.Menu);
        }
    }
}