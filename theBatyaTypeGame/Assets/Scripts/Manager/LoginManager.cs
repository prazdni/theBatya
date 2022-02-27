using System;
using Danil.Scripts.Interface;
using UnityEngine;

namespace Manager
{
    public class LoginManager : MonoBehaviour, IAsyncManager
    {
        public Action onScoreChanged;

        public bool done { get; }

        private int _score;
        private bool _done;

        private void Awake()
        {
            // code for playfab
        }
    }
}