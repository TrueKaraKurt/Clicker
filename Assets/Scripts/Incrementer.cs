using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Incrementer
{
    private float _sushiCount;
    public void IncreaseSushiCount()
    {
        _sushiCount++;
        SaveSushiCount();
    }
    public void IncreaseSushiCountPerSec(float sushiGain) 
    {
        _sushiCount += sushiGain;
    }

    public float GetSushiCount()
    {
        return _sushiCount;
    }
    public bool DecreaseSushiCount(float upgradeCost)
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
        PlayerPrefs.SetFloat("money", _sushiCount);
    }
    public void LoadSushiCount()
    {
        _sushiCount = PlayerPrefs.GetFloat("money");
    }



}
