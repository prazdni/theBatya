using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuLogic : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartGame()
    {
        SceneTransition.SwitchToScene("");
    }

    public void ChangeSound()
    {

    }

    public void ChangeDifficulty()
    {

    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
