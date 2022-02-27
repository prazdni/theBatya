using Danil.Scripts;
using UnityEngine;
using UnityEngine.UI;

public class PlayButtonsWidget : MonoBehaviour
{
    [SerializeField] private Button _playOfflineButton;
    [SerializeField] private Button _playOnlineButton;

    private void Start()
    {
        _playOfflineButton.onClick.AddListener(OnPlayOfflineClick);
        _playOnlineButton.onClick.AddListener(OnPlayOnlineClick);
    }

    private void OnDestroy()
    {
        _playOfflineButton.onClick.RemoveListener(OnPlayOfflineClick);
        _playOnlineButton.onClick.RemoveListener(OnPlayOnlineClick);
    }

    private void OnPlayOfflineClick()
    {
        StateManager.Instance.SetState(State.OfflineGame);
    }
    
    private void OnPlayOnlineClick()
    {
        StateManager.Instance.SetState(State.OnlineGame);
    }
}
