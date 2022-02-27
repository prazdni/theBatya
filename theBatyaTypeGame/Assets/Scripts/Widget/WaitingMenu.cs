using UnityEngine;

namespace Danil.Scripts
{
    public class WaitingMenu : MonoBehaviour
    {
        [SerializeField] private GameObject _root;

        private void Start()
        {
            OnStateChanged(StateManager.Instance.currentState);

            StateManager.Instance.onStateChanged += OnStateChanged;
        }

        private void OnDestroy()
        {
            StateManager.Instance.onStateChanged -= OnStateChanged;
        }
        
        private void OnStateChanged(State state)
        {
            _root.SetActive(state == State.Waiting);
        }
    }
}