using System;
using TMPro;
using UnityEngine;

public class PrefabPersonalData : MonoBehaviour
{
    [SerializeField] private int _prefabIndex;

    private string _upgradeName;
    private decimal _upgradeBuyPrice;
    private decimal _upgradeProductivity;
    private decimal _priceIncrease;
    private int _upgradeCount;

    private decimal _currentBuyPrice;

    [SerializeField] private TextMeshProUGUI _displayedName;
    [SerializeField] private TextMeshProUGUI _displayedBuyPrice;
    [SerializeField] private TextMeshProUGUI _displayedProductivity;
    [SerializeField] private TextMeshProUGUI _displayedCount;
    public void Initializer(string upgradeName, decimal upgradeBuyPrice, decimal upgradeProductivity, decimal priceIncrease, int upgradeCount)
    {
        _upgradeName = upgradeName;
        _upgradeBuyPrice = upgradeBuyPrice;
        _upgradeProductivity = upgradeProductivity;
        _priceIncrease = priceIncrease;
        _upgradeCount = upgradeCount;

        _currentBuyPrice = _upgradeBuyPrice;
        SetUpgradeCount();
    }
    public void UpdateDataDisplay() 
    {
        _currentBuyPrice = CalcActualPrice(_prefabIndex, _upgradeCount);
        _displayedName.text = _upgradeName.ToString();
        _displayedBuyPrice.text = NumConvert.ToLongNumberdDisplayer(_currentBuyPrice).ToString();
        _displayedProductivity.text = NumConvert.ToLongNumberdDisplayer(_upgradeProductivity).ToString();
        _displayedCount.text = _upgradeCount.ToString("G30");
    }
    public void SetUpgradeCount() 
    {
        _upgradeCount = AutoAddit.Instance.GetUpgradeCount(_prefabIndex);
    }

    private decimal CalcActualPrice(int index, int upgradeCount)
    {
        decimal temp;
        decimal currentPrice = _upgradeBuyPrice;
        temp = Math.Floor(currentPrice * (decimal)Math.Pow((double)_priceIncrease, upgradeCount));
        return temp;
    }

    public void UpgradeBuying()
    {
        _currentBuyPrice = CalcActualPrice(_prefabIndex, _upgradeCount);
        if (Incrementer.Instance.DecreaseSushiCount(_currentBuyPrice))
        {
            AutoAddit.Instance.AddDataToUpgradeCountArray(_prefabIndex);
            _upgradeCount = AutoAddit.Instance.GetUpgradeCount(_prefabIndex);
            SetUpgradeCount();
            UpdateDataDisplay();
        }
    }
}
