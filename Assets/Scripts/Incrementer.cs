using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Incrementer : MonoBehaviour
{
    [SerializeField] private int _sushiCount;
    [SerializeField] private Text _sushiCountDisplay;

    public void OnSushiClick() 
    {
        IncreaseSushiCount();
    }

    private void IncreaseSushiCount()
    {
        _sushiCount++;
    }
}
