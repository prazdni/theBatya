using Danil.Scripts;
using Manager;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public enum Difficulty
{
    Rook,
    Brave,
    Fighter
}

public class DifficultyWidget : MonoBehaviour
{
    [SerializeField] private Button _difficultyButton;
    [SerializeField] private TMP_Text _difficultyText;
    [SerializeField] private TMP_Text _conditionText;
    [SerializeField] private ScoreManager _scoreManager;

    private Difficulty _difficulty;

    const int BraveScore = 5;
    const int FighterScore = 10;

    private void Start()
    {
        OnStateChanged(StateManager.Instance.currentState);

        StateManager.Instance.onStateChanged += OnStateChanged;
        _difficultyButton.onClick.AddListener(ChangeDifficulty);
    }

    private void OnDestroy()
    {
        StateManager.Instance.onStateChanged -= OnStateChanged;
        _difficultyButton.onClick.RemoveListener(ChangeDifficulty);
    }

    private void OnStateChanged(State state)
    {
        if (state != State.Menu)
            return;

        int score = _scoreManager.score;
        if (score < 5)
            _difficulty = Difficulty.Rook;
        else if (score < 10)
            _difficulty = Difficulty.Brave;
        else
            _difficulty = Difficulty.Fighter;

        SetDifficulty();
    }

    private void SetDifficulty()
    {
        switch (_difficulty)
        {
            case Difficulty.Rook:
                _difficultyText.text = "Новобранец";
                _conditionText.gameObject.SetActive(false);
                break;
            case Difficulty.Brave:
                _difficultyText.text = "Смельчак";
                _conditionText.gameObject.SetActive(_scoreManager.score < BraveScore);
                _conditionText.text = $"Побори зависимость {BraveScore - _scoreManager.score} раз";

                break;
            case Difficulty.Fighter:
                _difficultyText.text = "Боец";
                _conditionText.gameObject.SetActive(_scoreManager.score < FighterScore);
                _conditionText.text = $"Побори зависимость {FighterScore - _scoreManager.score} раз";
                break;
        }
    }

    private void ChangeDifficulty()
    {
        var difficulty = (int)_difficulty;
        difficulty++;
        if (difficulty > 2)
            difficulty = 0;
        _difficulty = (Difficulty)difficulty;

        SetDifficulty();
    }
}
