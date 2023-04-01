using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Incrementer : MonoBehaviour
{
    [SerializeField] private int _sushiCount;
    [SerializeField] private Text _sushiCountDisplay;
    public void IncreaseSushiCount()
    {
        _sushiCount++;
    }
    private void Update()
    {
        _sushiCountDisplay.text = _sushiCount.ToString();
    }
}
