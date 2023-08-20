using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UpgradePersonalData : MonoBehaviour
{
    [SerializeField] private int _prefabIndex;

    private string _upgradeName;
    private Sprite _upgradeIcon;
    private decimal _upgradeBuyPrice;
    private decimal _upgradeProductivity;
    private decimal _priceIncrease;
    private int _upgradeCount;

    private decimal _currentBuyPrice;

    [SerializeField] private TextMeshProUGUI _displayedUpgradeName;
    [SerializeField] private TextMeshProUGUI _displayedUpgradeBuyPrice;
    [SerializeField] private TextMeshProUGUI _displayedUpgradeProductivity;
    [SerializeField] private TextMeshProUGUI _displayedUpgradeCount;
    [SerializeField] private Sprite _displayedUpgradeIcon;

    private void Start()
    {
        Initializer(_prefabIndex);
        UpdateDataDisplay();
    }
    private void Initializer(int index)
    {

        _upgradeName = Upgrade.updates[index].upgradeName;
        _upgradeBuyPrice = Upgrade.updates[index].upgradeBuyPrice;
        _upgradeProductivity = Upgrade.updates[index].upgradeProductivity;
        _priceIncrease = Upgrade.updates[index].priceIncrease;
        _upgradeIcon = Upgrade.updates[index].upgradeIcon;

        SetUpgradeCount();
    }
    private void UpdateDataDisplay() 
    {
        _currentBuyPrice = CalcActualPrice(_prefabIndex, _upgradeCount);
        _displayedUpgradeName.text = _upgradeName;
        _displayedUpgradeBuyPrice.text = NumConvert.ToLongNumberdDisplayer(_currentBuyPrice).ToString();
        _displayedUpgradeProductivity.text = NumConvert.ToLongNumberdDisplayer(_upgradeProductivity).ToString();
        _displayedUpgradeCount.text = _upgradeCount.ToString("G30");
        _displayedUpgradeIcon = _upgradeIcon;    
    }
    private void SetUpgradeCount() 
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
