using Danil.Scripts;
using UnityEngine;
using UnityEngine.UI;

public class RulesButtonWidget : MonoBehaviour
{
    [SerializeField] private Button _rulesButton;

    private void Start()
    {
        _rulesButton.onClick.AddListener(OnRulesButtonClick);
    }

    private void OnDestroy()
    {
        _rulesButton.onClick.RemoveListener(OnRulesButtonClick);
    }

    private void OnRulesButtonClick()
    {
        StateManager.Instance.SetState(State.Rules);
    }
}