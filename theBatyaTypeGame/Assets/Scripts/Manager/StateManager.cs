using System;
using UnityEngine;

namespace Danil.Scripts
{
    public enum State
    {
        Entry,
        Waiting,
        Menu,
        Rules,
        FindOpponent,
        OfflineGame,
        OnlineGame
    }

    public class StateManager : MonoBehaviour
    {
        public event Action<State> onStateChanged;

        public static StateManager Instance;

        public State currentState => _currentState;

        private State _currentState;

        private void Awake()
        {
            if (Instance == null)
            {
                DontDestroyOnLoad(gameObject);
                Instance = this;
                SetState(State.Menu);
            }
            else
            {
                Destroy(gameObject);
            }
        }

        public void SetState(State state)
        {
            _currentState = state;

            onStateChanged?.Invoke(_currentState);
        }
    }
}