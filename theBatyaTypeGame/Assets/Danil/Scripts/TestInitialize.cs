using System;
using UnityEngine;

namespace Danil.Scripts
{
    public class TestInitialize : MonoBehaviour
    {
        private void Awake()
        {
            PlayerPrefs.SetInt("Difficulty", 0);
        }
    }
}