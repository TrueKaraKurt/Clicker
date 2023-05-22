using UnityEngine;
using TMPro;
using System;

public class PowerUpsPersonalData : MonoBehaviour
{
    [SerializeField] private int _prefabIndex;

    private string _powerUpsName;
    private decimal _powerUpsPrice;
    private decimal _priceIncrease;
    private int _powerUpsLevel;
    private int _powerUpsMaxLevel;
    private string _powerUpsDescription;

    private decimal _currentBuyPrice;

    [SerializeField] private TextMeshProUGUI _displayedPowerUpsName;
    [SerializeField] private TextMeshProUGUI _displayedPowerUpsPrice;
    [SerializeField] private TextMeshProUGUI _displayedPowerUpsLevel;
    [SerializeField] private TextMeshProUGUI _displayedPowerUpsDescription;

    private void Start()
    {
        Initializer(_prefabIndex);
        UpdateDataDisplay();
    }

    private void Initializer(int index)
    {

        _powerUpsName = PowerUp.powerUps[index].powerUpName;
        _powerUpsPrice = PowerUp.powerUps[index].powerUpBuyPrice;
        _priceIncrease = PowerUp.powerUps[index].priceIncrease;
        _powerUpsLevel = LoadPowerUpsLevel();
        _powerUpsMaxLevel = PowerUp.powerUps[index].maxLevel;
        _powerUpsDescription = PowerUp.powerUps[index].powerUpEffect;
        SendPowerUpsLevel();

    }
    private void UpdateDataDisplay()
    {
        _currentBuyPrice = CalcActualPrice(_prefabIndex, _powerUpsLevel);
        _displayedPowerUpsName.text = _powerUpsName;
        _displayedPowerUpsPrice.text = NumConvert.ToLongNumberdDisplayer(_currentBuyPrice).ToString();
        _displayedPowerUpsLevel.text = _powerUpsLevel.ToString("G30");
        _displayedPowerUpsDescription.text = _powerUpsDescription;
    }
    private decimal CalcActualPrice(int index, int upgradeCount)
    {
        decimal temp;
        decimal currentPrice = _powerUpsPrice;
        temp = Math.Floor(currentPrice * (decimal)Math.Pow((double)_priceIncrease, upgradeCount));
        return temp;
    }

    public void UpgradeBuying()
    {
        _currentBuyPrice = CalcActualPrice(_prefabIndex, _powerUpsLevel);
        if (_powerUpsLevel < _powerUpsMaxLevel)
        {
            if (Incrementer.Instance.DecreaseSushiCount(_currentBuyPrice))
            {

                _powerUpsLevel++;
                SavePowerUpsLevel();
                UpdateDataDisplay();
                SendPowerUpsLevel();
            }
        }
        
    }
    private void SavePowerUpsLevel()
    {
        PlayerPrefs.SetInt("powerUpsLevel", _powerUpsLevel);
    }
    private int LoadPowerUpsLevel()
    {
        return PlayerPrefs.GetInt("powerUpsLevel");
    }

    private void SendPowerUpsLevel()
    {
        Incrementer.OnPowerUpsUsage?.Invoke(_powerUpsLevel, (Incrementer.PowerUps)_prefabIndex);
    }
}
