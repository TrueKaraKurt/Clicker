using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Incrementer : MonoBehaviour
{
    public static Incrementer Instance => _instance;
    private static Incrementer _instance;
    private void Awake()
    {
        _instance = this;
    } 

    private decimal _sushiCount;
    public void IncreaseSushiCount()
    {
        _sushiCount++;
        SaveSushiCount();
    }
    public void IncreaseSushiCountPerSec(decimal sushiGain) 
    {
        _sushiCount += sushiGain;
    }

    public decimal GetSushiCount()
    {
        return _sushiCount;
    }
    public bool DecreaseSushiCount(decimal upgradeCost)
    {
        if (_sushiCount >= upgradeCost)
        {
            _sushiCount -= upgradeCost;
            return true;
        }
        else 
        {
            return false;
        }
        
    }
    public void SaveSushiCount()
    {
        PlayerPrefs.SetFloat("money",(float)_sushiCount);
    }
    public void LoadSushiCount()
    {
        _sushiCount = Convert.ToDecimal(PlayerPrefs.GetFloat("money"));
    }
}
