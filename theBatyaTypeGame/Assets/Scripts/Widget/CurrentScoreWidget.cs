using Danil.Scripts;
using Manager;
using TMPro;
using UnityEngine;

public class CurrentScoreWidget : MonoBehaviour
{
    [SerializeField] private ScoreManager _scoreManager;
    [SerializeField] private TMP_Text _currentScoreText;

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
        if (state != State.Menu)
            return;

        _currentScoreText.text = $"Поборол зависимость {_scoreManager.score} раз";
    }
}
