using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PrefabPersonalData : MonoBehaviour
{
    [SerializeField] private int _prefabIndex;

    private string _upgradeName;
    //private Sprite _upgradeIcon;
    private decimal _upgradeBuyPrice;
    private decimal _upgradeProductivity;
    private decimal _priceIncrease;
    private int _upgradeCount;

    private decimal _currentBuyPrice;

    [SerializeField] private TextMeshProUGUI _displayedName;
    //[SerializeField] private Image _displayedIcon;
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
        _displayedBuyPrice.text = _currentBuyPrice.ToString("G30");
        _displayedProductivity.text = _upgradeProductivity.ToString("G30");
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
        if (upgradeCount == 0)
        {
            temp = currentPrice;
        }
        else
        {
            temp = Math.Floor(currentPrice * (decimal)Math.Pow((double)_priceIncrease, upgradeCount - 1));
        }
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
