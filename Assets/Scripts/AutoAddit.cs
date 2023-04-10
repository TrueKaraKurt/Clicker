using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AutoAddit : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _sushiCountDisplay;

    [SerializeField] private Transform _parantPrefab;
    [SerializeField] private List<PrefabPersonalData> _upgrades;

    private int[] _upgradeCount;

    public static AutoAddit Instance => _instance;
    private static AutoAddit _instance;
    private void Awake()
    {
        _instance = this;
    }

    private void Start()
    {
        Incrementer.Instance.LoadSushiCount();
        InitializationUpgradeKit();
        StartCoroutine(AutoSushiGain());
        DisplayData();
    }

    private void Update()
    {
        _sushiCountDisplay.text = Incrementer.Instance.GetSushiCount().ToString();
    }
    public void OnClickEvent()
    {
        Incrementer.Instance.IncreaseSushiCount();
    }

    private void InitializationUpgradeKit() 
    {
        _upgradeCount = new int[Upgrade.updates.Count];
        LoadUpgrade();
        _upgrades = _parantPrefab.GetComponentsInChildren<PrefabPersonalData>().ToList();

        for (int i = 0; i < _upgrades.Count; i++)
        {
            _upgrades[i].Initializer(
                Upgrade.updates[i].upgradeName,
                Upgrade.updates[i].upgradeBuyPrice,
                Upgrade.updates[i].upgradeProductivity,
                Upgrade.updates[i].priceIncrease,
                _upgradeCount[i]);
        }
    }

    private void DisplayData()
    {
        for (int i = 0; i < _upgrades.Count; i++)
        {
            _upgrades[i].UpdateDataDisplay();
        }
    }
    public void AddDataToUpgradeCountArray(int index) 
    {
        _upgradeCount[index]++;
    }
    public int GetUpgradeCount(int index) 
    {
        return _upgradeCount[index];
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
            Incrementer.Instance.IncreaseSushiCountPerSec(SushiPerSecond());
            SaveUpgrade();
            DisplayData();
            Incrementer.Instance.SaveSushiCount();
            yield return new WaitForSeconds(1);
        }
    }

    private string CompressString(int[] str)
    {
        string data = "[";
        for (int i = 0; i < str.Length; i++)
            data += i + ":" + str[i] + ",";
        data = data.Remove(data.Length - 1) + "]";

        return data;
    }
    private bool DecompressString(string str, out int[] array)
    {
        //[0:0,1:1,2:0,3:0,4:1,5:0,6:0,7:1,8:0]
        List<int> list = new List<int>();
        array = new int[] { };
        if (str != "")
        {
            string number = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '[' || str[i] == ':')
                {
                    number = "";
                    continue;
                }
                if (str[i] == ',' || str[i] == ']')
                {
                    list.Add(Convert.ToInt32(number));
                    number = "";
                }
                number += str[i];
            }
            array = list.ToArray();
            return true;
        }
        else
        {
            return false;
        }
        
    }
    private void SaveUpgrade()
    {
        PlayerPrefs.SetString("upgradeCount", CompressString(_upgradeCount));
        //Debug.Log("save succsess - " + PlayerPrefs.GetString("upgradeCount"));
    }
    private void LoadUpgrade()
    {
        if (DecompressString(PlayerPrefs.GetString("upgradeCount"), out int[] upgradeCount))
        {
            _upgradeCount = upgradeCount;
        }
        //Debug.Log("load succsess - " + _upgradeCount);
    }
    public void ResetUpgrades()
    {
        PlayerPrefs.DeleteKey("upgradeCount");
        _upgradeCount = new int[Upgrade.updates.Count];
        Debug.Log(_upgradeCount[1]);
        InitializationUpgradeKit();
    }
}
