using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class Incrementer : MonoBehaviour
{
    public static Incrementer Instance => _instance;
    private static Incrementer _instance;

    public static Action<int, PowerUps> OnPowerUpsUsage;

    public static event Action<decimal, bool> OnSushiClick;

    private decimal _sushiCount;

    private int _currentLevelOfClickPower;
    private int _currentLevelOfCritChance;
    private int _currentLevelOfCritPower;

    private decimal _baseCritPower = 2;

    public enum PowerUps 
    {
        ClickPower = 0,
        CritChance = 1,
        CritPower = 2
    }
    private void Awake()
    {
        _instance = this;
        OnPowerUpsUsage += GetPowerUpsCurrentLevel;
    }
    private void OnDestroy()
    {
        OnPowerUpsUsage -= GetPowerUpsCurrentLevel;
    }
    public void IncreaseSushiCount(decimal inputSishi = 2m, bool cheat = false)
    {
        if (cheat)
        {
            _sushiCount += inputSishi;
            return;
        }

        inputSishi = (decimal)Math.Pow((double)inputSishi,_currentLevelOfClickPower);
        decimal currentClick = CritCalculate(inputSishi, out bool isCrit);
        OnSushiClick?.Invoke(currentClick, isCrit);
        _sushiCount += currentClick;
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
        string mySushi = _sushiCount.ToString();
        PlayerPrefs.SetString("money",mySushi);
    }
    public void LoadSushiCount()
    {
        if (PlayerPrefs.GetString("money") != "")
        {
            _sushiCount = decimal.Parse(PlayerPrefs.GetString("money"));
        }
    }

    private decimal CritCalculate(decimal clickPower, out bool isCrit)
    {
        isCrit = false;
        if (Random.Range(0, 100) < _currentLevelOfCritChance)
        {
            Debug.Log("Critical Click");
            isCrit = true;
            return clickPower * (_baseCritPower + 0.5m * _currentLevelOfCritPower);
        }
        return clickPower;
    }
    public void ResetSushiCount()
    {
        PlayerPrefs.DeleteKey("money");
        _sushiCount = 0;
    }

    private void GetPowerUpsCurrentLevel(int powerUpsLevel, PowerUps currentPowerUps)
    {
        switch (currentPowerUps)
        {
            case PowerUps.ClickPower:
                _currentLevelOfClickPower = powerUpsLevel;
                break;
            case PowerUps.CritChance:
                _currentLevelOfCritChance = powerUpsLevel;
                break;
            case PowerUps.CritPower:
                _currentLevelOfCritPower = powerUpsLevel;
                break;
        }
    }
}

