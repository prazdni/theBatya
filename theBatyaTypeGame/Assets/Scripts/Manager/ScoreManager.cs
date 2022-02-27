using System;
using Danil.Scripts.Interface;
using UnityEngine;

namespace Manager
{
    public class ScoreManager : MonoBehaviour, IAsyncManager
    {
        public Action onScoreChanged;

        public int score { get; }
        public bool done { get; }

        private int _score;
        private bool _done;

        private void Awake()
        {
            // code for playfab
        }
    }
}