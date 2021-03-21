using UnityEngine;

namespace Danil.Scripts
{
    public class TestInitialize : MonoBehaviour
    {
        private void Awake()
        {
            AllStatic.LEVEL = PlayerPrefs.GetInt("PlayerDifficulty", 0);
            Screen.SetResolution(1080, 1920, FullScreenMode.FullScreenWindow);

            Time.timeScale = 1.0f;
        }
    }
}