using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Danil.Scripts;
using System.Data;
using System.Linq;
using Random = UnityEngine.Random;

public class InputConditionManager : MonoBehaviour
{
    [SerializeField] private PhraseOutput _phraseOutput;
    [SerializeField] private InputLetters _inputLetters;

    private string _phraseToCheck;
    private int _level = 0;
    private int _phrasePreparation = 0;

    private void Start()
    {
        _inputLetters.InputField.onValueChanged.AddListener(OnValueChanged);
        PrepareText(_phrasePreparation);
    }

    private void PrepareText(int index)
    {
        if (index == 0)
        {
            _phraseToCheck = AllStatic.DRINK;
        }
        if (index == 1)
        {
            _phraseToCheck = AllStatic.SMOKE;
        }
        if (index == 2)
        {
            _phraseToCheck = AllStatic.USE;
        }

        var phrase = _phraseToCheck;
        
        _phraseToCheck = _phraseToCheck.Replace(" ", "").ToLower();
        
        var charStr = _phraseToCheck.Distinct().ToList();
        var randChar = charStr[Random.Range(0, charStr.Count)];

        var randCharToReplace = AllStatic.ALPHABET[Random.Range(0, AllStatic.ALPHABET.Count)];
        
        var wordsToAdd = $", где {randChar} это {randCharToReplace}";
        _phraseOutput.ChangePhrase(phrase + wordsToAdd);

        _phraseToCheck = _phraseToCheck.Replace(randChar, randCharToReplace);
        Debug.Log(_phraseToCheck);
    }

    private void OnValueChanged(string str)
    {
        str = str.Replace(" ", "").ToLower();
        Debug.Log(_phraseToCheck + " " + str);
        
        if (_phraseToCheck.StartsWith(str))
        {
            if (str.Length == _phraseToCheck.Length)
            {
                _inputLetters.OnAnswer(true);
                _phrasePreparation++;
                PrepareText(_phrasePreparation % 3);
            }
        }
        else
        {
            _inputLetters.OnAnswer(false);
        }
    }
}
