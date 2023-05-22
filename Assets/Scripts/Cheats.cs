using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Cheats : MonoBehaviour
{
    [SerializeField] private TMP_InputField _inputSushiCount;

    public void AddCheatedSushi()
    {
        string temp;
        temp = _inputSushiCount.text;
        decimal outputSushi;
        outputSushi = Convert.ToDecimal(temp);
        Incrementer.Instance.IncreaseSushiCount(outputSushi, true);
        _inputSushiCount.text = null;
    }
}
