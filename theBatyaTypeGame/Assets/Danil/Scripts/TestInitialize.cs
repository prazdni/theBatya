using System;
using UnityEngine;

namespace Danil.Scripts
{
    public class TestInitialize : MonoBehaviour
    {
        private void Awake()
        {
            PlayerPrefs.SetInt("Difficulty", 0);
            Screen.SetResolution(1080, 1920, FullScreenMode.FullScreenWindow);
        }
    }
}