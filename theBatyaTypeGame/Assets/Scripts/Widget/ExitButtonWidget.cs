using UnityEngine;
using UnityEngine.UI;

public class ExitButtonWidget : MonoBehaviour
{
    [SerializeField] private Button _exitButton;

    private void Start()
    {
        _exitButton.onClick.AddListener(OnExitButtonClick);
    }

    private void OnDestroy()
    {
        _exitButton.onClick.RemoveListener(OnExitButtonClick);
    }

    private void OnExitButtonClick()
    {
        Application.Quit();
    }
}