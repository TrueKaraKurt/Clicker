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
            _upgradeCountDisplay[i].text = _upgradeCount[i].ToString();
        }

        for (int i = 0; i < Upgrade.updates.Count; i++)
        {
            int currentPrice = Upgrade.updates[i].upgradeBuyPrice;
            float temp = currentPrice + (currentPrice * Upgrade.updates[i].priceIncrease * _upgradeCount[i]);
            _upgradeCost[i].text = temp.ToString();
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
    private float CalcActualPrice(int index) 
    {
        float temp;
        int currentPrice = Upgrade.updates[index].upgradeBuyPrice;
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
        float temp = CalcActualPrice(index);
        if (incrementer.DecreaseSushiCount(temp))
        {
            _upgradeCount[index]++;


            temp = CalcActualPrice(index);

            _upgradeCost[index].text = temp.ToString();
            _upgradeCountDisplay[index].text = _upgradeCount[index].ToString();
        }
    }
    private float SushiPerSecond() 
    {
        float totalSushiPerSecond = 0;
        for (int i = 0; i < _upgradeCount.Length; i++)
        {
            float temp = Upgrade.updates[i].upgradeProductivity;
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
    public void SetMiltiplier(int multip)
    {
        incrementer.SetMultiplier(multip);
    }
}
