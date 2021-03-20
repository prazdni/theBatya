using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Danil.Scripts;
using System.Data;
using System.Linq;

public class InputConditionManager : MonoBehaviour
{

    private List<string> _dependenceList = new List<string>();
    private int _difficulty;
    private List<char> _alphaList;
    PasteLetter _pasteLetter;
    string _stringToCheck;

    // Start is called before the first frame update
    void Start()
    {
        _pasteLetter._inputField.onValueChanged.AddListener(OnValueChanged);
        _dependenceList.Add("Я не буду пить");
        _dependenceList.Add("Я не буду курить");
        _dependenceList.Add("Я не буду наркоманить");
    }


    public bool IsCorrect(string input)
    {
        return input.Equals(_stringToCheck);
    }

    private void OnValueChanged(string dependence)
    {
        string str = dependence;
        str = str.Replace(" ", "");
        var charStr = str.Distinct().ToList();

        var randChar = charStr[Random.Range(0, charStr.Count)];

        var dic = new List<char>
            {
                'а', 'б', 'в', 'г'
            };

        var randCharToReplace = dic[Random.Range(0, dic.Count)];

        var stringToWrite = dependence + ", где" + randChar + " = " + randCharToReplace;

        Debug.Log(stringToWrite);

        var stringToCheck = str.Replace(randChar, randCharToReplace);
        _stringToCheck = stringToCheck;
    }
}
