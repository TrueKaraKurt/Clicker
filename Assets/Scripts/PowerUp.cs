using System;
using System.Collections.Generic;

[Serializable]
public struct ClickUpgradeData
{
    public string powerUpName;
    public int powerUpIndex;
    public decimal powerUpBuyPrice;
    public decimal priceIncrease;
    public int maxLevel;
    public string powerUpEffect;
}
public static class PowerUp
{
    public static List<ClickUpgradeData> powerUps => _updates;
    private static List<ClickUpgradeData> _updates = new List<ClickUpgradeData>()
    {
        new ClickUpgradeData
        {
            powerUpName = "Power Click",
            powerUpIndex = 0,
            powerUpBuyPrice = 1000,
            priceIncrease = 2.5m,
            maxLevel = 20,
            powerUpEffect = "Double click power",

        },
        new ClickUpgradeData
        {
            powerUpName = "Sharp click",
            powerUpIndex = 1,
            powerUpBuyPrice = 100,
            priceIncrease = 2,
            maxLevel = 15,
            powerUpEffect = "Add 1% to crit chance per level",
        },
        new ClickUpgradeData
        {
            powerUpName = "Mighty click",
            powerUpIndex = 2,
            powerUpBuyPrice = 100000,
            priceIncrease = 2,
            maxLevel = 6,
            powerUpEffect = "Add 50% to crit power per level",
        },
        new ClickUpgradeData
        {
            powerUpName = "Golden hashi",
            powerUpIndex = 3,
            powerUpBuyPrice = 10000,
            priceIncrease = 12,
            maxLevel = 4,
            powerUpEffect = "x10 to hashi production per level",
        },
        new ClickUpgradeData
        {
            powerUpName = "Offline production",
            powerUpIndex = 4,
            powerUpBuyPrice = 1000,
            priceIncrease = 10,
            maxLevel = 20,
            powerUpEffect = "Add 5% offline production per level",
        },
        new ClickUpgradeData
        {
            powerUpName = "Plug",
            powerUpIndex = 4,
            powerUpBuyPrice = 1000,
            priceIncrease = 10,
            maxLevel = 20,
            powerUpEffect = "Plug",
        },
        new ClickUpgradeData
        {
            powerUpName = "Plug",
            powerUpIndex = 4,
            powerUpBuyPrice = 1000,
            priceIncrease = 10,
            maxLevel = 20,
            powerUpEffect = "Plug",
        },
        new ClickUpgradeData
        {
            powerUpName = "Plug",
            powerUpIndex = 4,
            powerUpBuyPrice = 1000,
            priceIncrease = 10,
            maxLevel = 20,
            powerUpEffect = "Plug",
        },
        new ClickUpgradeData
        {
            powerUpName = "Plug",
            powerUpIndex = 4,
            powerUpBuyPrice = 1000,
            priceIncrease = 10,
            maxLevel = 20,
            powerUpEffect = "Plug",
        },
        new ClickUpgradeData
        {
            powerUpName = "Plug",
            powerUpIndex = 4,
            powerUpBuyPrice = 1000,
            priceIncrease = 10,
            maxLevel = 20,
            powerUpEffect = "Plug",
        },
    };
}
