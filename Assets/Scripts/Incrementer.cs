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

    public float GetSushiCount()
    {
        return _sushiCount;
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
