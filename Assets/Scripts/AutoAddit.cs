using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AutoAddit : MonoBehaviour
{
    [SerializeField] private Text _sushiCountDisplay;
    Incrementer incrementer;

    [SerializeField] private List<Text> _upgradeCost;
    [SerializeField] private List<Text> _upgradeCountDisplay;

    private int[] _upgradeCount;
    //private float[] _upgradeCost;

    private void Start()
    {
        incrementer = new Incrementer();
        incrementer.LoadSushiCount();

        InitializationUpgradeKit();
        StartCoroutine(AutoSushiGain());
    }

    private void Update()
    {
        _sushiCountDisplay.text =incrementer.GetSushiCount().ToString();
    }
    public void OnClickEvent()
    {
        incrementer.IncreaseSushiCount();
    }

    private void InitializationUpgradeKit() 
    {
        _upgradeCount = new int[Upgrade.updates.Count];
        for (int i = 0; i < _upgradeCount.Length; i++)
        {
            _upgradeCountDisplay[i].text = _upgradeCount[i].ToString("G30");
        }

        for (int i = 0; i < Upgrade.updates.Count; i++)
        {
            decimal currentPrice = Upgrade.updates[i].upgradeBuyPrice;
            decimal temp = currentPrice + (currentPrice * Upgrade.updates[i].priceIncrease * _upgradeCount[i]);
            _upgradeCost[i].text = temp.ToString("G30");
        }
    }
    private void DisplayNewPrice() 
    {
        foreach (var item in _upgradeCost)
        {

        }
    }
    private void SaveUpgrade()
    {

    }
    private void LoadUpgrade()
    {

    }
    private decimal CalcActualPrice(int index) 
    {
        decimal temp;
        decimal currentPrice = Upgrade.updates[index].upgradeBuyPrice;
        if (_upgradeCount[index] == 0)
        {
            temp = currentPrice;
        }
        else
        {
            temp = currentPrice * Upgrade.updates[index].priceIncrease * _upgradeCount[index];
        };
        return temp;
    }

    public void UpgradeBuying(int index) 
    {
        decimal temp = CalcActualPrice(index);
        if (incrementer.DecreaseSushiCount(temp))
        {
            _upgradeCount[index]++;


            temp = CalcActualPrice(index);

            _upgradeCost[index].text = temp.ToString("G30");
            Debug.Log(Convert.ToDecimal(Upgrade.updates[29].upgradeBuyPrice).ToLongNumberdDisplayer());
            _upgradeCountDisplay[index].text = _upgradeCount[index].ToString("G30");
        }
    }
    private decimal SushiPerSecond() 
    {
        decimal totalSushiPerSecond = 0;
        for (int i = 0; i < _upgradeCount.Length; i++)
        {
            decimal temp = Convert.ToDecimal(Upgrade.updates[i].upgradeProductivity);
            totalSushiPerSecond += _upgradeCount[i] * temp;
        }

        return totalSushiPerSecond;
    }
    IEnumerator AutoSushiGain()
    {
        while (true)
        {
            incrementer.IncreaseSushiCountPerSec(SushiPerSecond());
            yield return new WaitForSeconds(1);
        }
    }
    
}
