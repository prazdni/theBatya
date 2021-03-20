using System;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Danil.Scripts
{
    public class EndMessage : MonoBehaviour
    {
        [SerializeField] private Score _score;

        private TMP_Text _text;
        
        private void Awake()
        {
            _text = GetComponent<TMP_Text>();
            var score = _score.ScoreCount.ToString();

            _text.text = $"Поздравляем, вы набрали {score} очков";

            //string str = "Я не буду пить";
            //str = str.Replace(" ", "");
            //var charStr = str.Distinct().ToList();
//
            //var randChar = charStr[Random.Range(0, charStr.Count)];
//
            //var dic = new List<char>
            //{
            //    'а', 'б', 'в', 'г'
            //};
//
            //var randCharToReplace = dic[Random.Range(0, dic.Count)];
//
            //var stringToWrite = "Я не буду пить, где" + randChar + " = " + randCharToReplace;
            //Debug.Log(stringToWrite);
//
            //var stringToCheck = str.Replace(randChar, randCharToReplace);
            
            //проверяем в методе stringToCheck и ввод пользователя
        }

        public void ShowScore()
        {
            
        }
    }
}