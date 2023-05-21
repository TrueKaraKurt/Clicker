using UnityEngine;


public class Incrementer : MonoBehaviour
{
    public static Incrementer Instance => _instance;
    private static Incrementer _instance;

    private decimal _sushiCount;
    private void Awake()
    {
        _instance = this;
    } 
    public void IncreaseSushiCount(decimal inputSishi = 1m)
    {
        _sushiCount+= inputSishi;
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
    public void ResetSushiCount()
    {
        PlayerPrefs.DeleteKey("money");
        _sushiCount = 0;
    }
}
