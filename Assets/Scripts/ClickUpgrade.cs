using System;
using System.Collections.Generic;

[Serializable]
public struct ClickUpgradeData
{
    public string upgrdeName;
    public int upgrareIndex;
    public decimal upgradeBuyPrice;
    public decimal priceIncrease;
    public int maxLevel;
    public string upgradeEffect;
}
public static class ClickUpgrade
{
    public static List<ClickUpgradeData> updates => _updates;
    private static List<ClickUpgradeData> _updates = new List<ClickUpgradeData>()
    {
        new ClickUpgradeData
        {
            upgrdeName = "Power Click",
            upgrareIndex = 0,
            upgradeBuyPrice = 1000,
            priceIncrease = 2.5m,
            maxLevel = 20,
            upgradeEffect = "Double click power",

        },
        new ClickUpgradeData
        {
            upgrdeName = "Sharp click",
            upgrareIndex = 1,
            upgradeBuyPrice = 100,
            priceIncrease = 2,
            maxLevel = 15,
            upgradeEffect = "Add 1% to crit chance per level",
        },
        new ClickUpgradeData
        {
            upgrdeName = "Mighty click",
            upgrareIndex = 2,
            upgradeBuyPrice = 100000,
            priceIncrease = 2,
            maxLevel = 20,
            upgradeEffect = "Add 50% to crit power per level",
        },
        new ClickUpgradeData
        {
            upgrdeName = "Durable hashi",
            upgrareIndex = 3,
            upgradeBuyPrice = 10000,
            priceIncrease = 12,
            maxLevel = 4,
            upgradeEffect = "x10 to hashi production per level",
        },
        new ClickUpgradeData
        {
            upgrdeName = "Offline production",
            upgrareIndex = 4,
            upgradeBuyPrice = 1000,
            priceIncrease = 10,
            maxLevel = 20,
            upgradeEffect = "Add 5% offline production per level",
        },
    };
}
