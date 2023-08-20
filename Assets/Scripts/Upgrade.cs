using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public struct UpgradeData
{
    public string upgradeName;
    public int upgrareIndex;
    public Sprite upgradeIcon;
    public decimal upgradeBuyPrice;
    public decimal priceIncrease;
    public decimal upgradeProductivity;
}
public static class Upgrade
{
    public static List<UpgradeData> updates => _updates;
    private static List<UpgradeData> _updates = new List<UpgradeData>()
    {
        new UpgradeData
        {
            upgradeName = "Hashi",
            upgrareIndex = 0,
            upgradeIcon = Resources.Load<Sprite>("Sprites/Hashi") ,
            upgradeBuyPrice = 10,
            priceIncrease = 1.15m,
            upgradeProductivity = 0.1m,
        },
        new UpgradeData
        {
            upgradeName = "Home cook",
            upgrareIndex = 1,
            //upgradeIcon =  ,
            upgradeBuyPrice = 100,
            priceIncrease = 1.15m,
            upgradeProductivity = 0.3m,
        },
        new UpgradeData
        {
            upgradeName = "Sushi master",
            upgrareIndex = 2,
            //upgradeIcon =  ,
            upgradeBuyPrice = 500,
            priceIncrease = 1.15m,
            upgradeProductivity = 0.5m,
        },
        new UpgradeData
        {
            upgradeName = "Sushi O-Matic",
            upgrareIndex = 3,
            //upgradeIcon =  ,
            upgradeBuyPrice = 2000,
            priceIncrease = 1.15m,
            upgradeProductivity = 1m,
        },
        new UpgradeData
        {
            upgradeName = "Sushi restaurant",
            upgrareIndex = 4,
            //upgradeIcon =  ,
            upgradeBuyPrice = 10000,
            priceIncrease = 1.15m,
            upgradeProductivity = 3m,
        },
        new UpgradeData
        {
            upgradeName = "Small sushi factory",
            upgrareIndex = 5,
            //upgradeIcon =  ,
            upgradeBuyPrice = 50000,
            priceIncrease = 1.15m,
            upgradeProductivity = 10m,
        },
        new UpgradeData
        {
            upgradeName = "Medium sushi factory",
            upgrareIndex = 6,
            //upgradeIcon =  ,
            upgradeBuyPrice = 200000,
            priceIncrease = 1.15m,
            upgradeProductivity = 20m,
        },
        new UpgradeData
        {
            upgradeName = "Big sushi factory",
            upgrareIndex = 7,
            //upgradeIcon =  ,
            upgradeBuyPrice = 500000,
            priceIncrease = 1.15m,
            upgradeProductivity = 40m,
        },
        new UpgradeData
        {
            upgradeName = "Sushi cloning machine",
            upgrareIndex = 8,
            //upgradeIcon =  ,
            upgradeBuyPrice = 1500000,
            priceIncrease = 1.15m,
            upgradeProductivity = 100m,
        },
        new UpgradeData
        {
            upgradeName = "Sushi cloning machine",
            upgrareIndex = 9,
            //upgradeIcon =  ,
            upgradeBuyPrice = 1500000,
            priceIncrease = 1.15m,
            upgradeProductivity = 100m,
        },
        new UpgradeData
        {
            upgradeName = "Sushi research institute",
            upgrareIndex = 10,
            //upgradeIcon =  ,
            upgradeBuyPrice = 5000000,
            priceIncrease = 1.15m,
            upgradeProductivity = 300m,
        },
        new UpgradeData
        {
            upgradeName = "Electron sushi",
            upgrareIndex = 11,
            //upgradeIcon =  ,
            upgradeBuyPrice = 15000000,
            priceIncrease = 1.15m,
            upgradeProductivity = 800m,
        },
        new UpgradeData
        {
            upgradeName = "Atomic sushi",
            upgrareIndex = 12,
            //upgradeIcon =  ,
            upgradeBuyPrice = 30000000,
            priceIncrease = 1.15m,
            upgradeProductivity = 1500m,
        },
        new UpgradeData
        {
            upgradeName = "Sushi Volcano",
            upgrareIndex = 13,
            //upgradeIcon =  ,
            upgradeBuyPrice = 100000000,
            priceIncrease = 1.15m,
            upgradeProductivity = 3000m,
        },
        new UpgradeData
        {
            upgradeName = "Earthquake sushi",
            upgrareIndex = 14,
            //upgradeIcon =  ,
            upgradeBuyPrice = 300000000,
            priceIncrease = 1.15m,
            upgradeProductivity = 5000m,
        },
        new UpgradeData
        {
            upgradeName = "Sushi tsunami",
            upgrareIndex = 15,
            //upgradeIcon =  ,
            upgradeBuyPrice = 1000000000,
            priceIncrease = 1.15m,
            upgradeProductivity = 10000m,
        },
        new UpgradeData
        {
            upgradeName = "Synthetic sushi",
            upgrareIndex = 16,
            //upgradeIcon =  ,
            upgradeBuyPrice = 2500000000,
            priceIncrease = 1.15m,
            upgradeProductivity = 20000m,
        },
        new UpgradeData
        {
            upgradeName = "Genetic sushi",
            upgrareIndex = 17,
            //upgradeIcon =  ,
            upgradeBuyPrice = 10000000000,
            priceIncrease = 1.15m,
            upgradeProductivity = 30000m,
        },
        new UpgradeData
        {
            upgradeName = "Sushi cyborg",
            upgrareIndex = 18,
            //upgradeIcon =  ,
            upgradeBuyPrice = 20000000000,
            priceIncrease = 1.15m,
            upgradeProductivity = 50000m,
        },
        new UpgradeData
        {
            upgradeName = "Alient sushi",
            upgrareIndex = 19,
            //upgradeIcon =  ,
            upgradeBuyPrice = 40000000000,
            priceIncrease = 1.15m,
            upgradeProductivity = 75000m,
        },
        new UpgradeData
        {
            upgradeName = "Alient sushi Lab",
            upgrareIndex = 20,
            //upgradeIcon =  ,
            upgradeBuyPrice = 60000000000,
            priceIncrease = 1.15m,
            upgradeProductivity = 100000m,
        },
        new UpgradeData
        {
            upgradeName = "Alient sushi tech",
            upgrareIndex = 21,
            //upgradeIcon =  ,
            upgradeBuyPrice = 100000000000,
            priceIncrease = 1.15m,
            upgradeProductivity = 150000m,
        },
        new UpgradeData
        {
            upgradeName = "Alient sushi AI",
            upgrareIndex = 22,
            //upgradeIcon =  ,
            upgradeBuyPrice = 250000000000,
            priceIncrease = 1.15m,
            upgradeProductivity = 300000m,
        },
        new UpgradeData
        {
            upgradeName = "Nano sushi",
            upgrareIndex = 23,
            //upgradeIcon =  ,
            upgradeBuyPrice = 500000000000,
            priceIncrease = 1.15m,
            upgradeProductivity = 500000m,
        },
        new UpgradeData
        {
            upgradeName = "Molecular sushi",
            upgrareIndex = 24,
            //upgradeIcon =  ,
            upgradeBuyPrice = 1000000000000,
            priceIncrease = 1.15m,
            upgradeProductivity = 750000m,
        },
        new UpgradeData
        {
            upgradeName = "Virus sushi",
            upgrareIndex = 25,
            //upgradeIcon =  ,
            upgradeBuyPrice = 1500000000000,
            priceIncrease = 1.15m,
            upgradeProductivity = 1000000m,
        },
        new UpgradeData
        {
            upgradeName = "Proto sushi",
            upgrareIndex = 26,
            //upgradeIcon =  ,
            upgradeBuyPrice = 3000000000000,
            priceIncrease = 1.15m,
            upgradeProductivity = 1500000m,
        },
        new UpgradeData
        {
            upgradeName = "Synaptic sushi",
            upgrareIndex = 27,
            //upgradeIcon =  ,
            upgradeBuyPrice = 7500000000000,
            priceIncrease = 1.15m,
            upgradeProductivity = 3000000m,
        },
        new UpgradeData
        {
            upgradeName = "Hydrogen sushi",
            upgrareIndex = 28,
            //upgradeIcon =  ,
            upgradeBuyPrice = 20000000000000,
            priceIncrease = 1.15m,
            upgradeProductivity = 5000000m,
        },
        new UpgradeData
        {
            upgradeName = "Uranium sushi",
            upgrareIndex = 29,
            //upgradeIcon =  ,
            upgradeBuyPrice = 50000000000000,
            priceIncrease = 1.15m,
            upgradeProductivity = 7500000m,
        },
        new UpgradeData
        {
            upgradeName = "Plutonium sushi",
            upgrareIndex = 30,
            //upgradeIcon =  ,
            upgradeBuyPrice = 100000000000000,
            priceIncrease = 1.15m,
            upgradeProductivity = 10000000m,
        },
        new UpgradeData
        {
            upgradeName = "Space sushi factory",
            upgrareIndex = 31,
            //upgradeIcon =  ,
            upgradeBuyPrice = 300000000000000,
            priceIncrease = 1.15m,
            upgradeProductivity = 15000000m,
        },
        new UpgradeData
        {
            upgradeName = "Sushi colonizator",
            upgrareIndex = 32,
            //upgradeIcon =  ,
            upgradeBuyPrice = 1000000000000000,
            priceIncrease = 1.15m,
            upgradeProductivity = 20000000m,
        },
        new UpgradeData
        {
            upgradeName = "Sushi star",
            upgrareIndex = 33,
            //upgradeIcon =  ,
            upgradeBuyPrice = 2000000000000000,
            priceIncrease = 1.15m,
            upgradeProductivity = 30000000m,
        },
        new UpgradeData
        {
            upgradeName = "sushi force",
            upgrareIndex = 34,
            //upgradeIcon =  ,
            upgradeBuyPrice = 5000000000000000,
            priceIncrease = 1.15m,
            upgradeProductivity = 50000000m,
        },
        new UpgradeData
        {
            upgradeName = "Dark sushi",
            upgrareIndex = 35,
            //upgradeIcon =  ,
            upgradeBuyPrice = 10000000000000000,
            priceIncrease = 1.15m,
            upgradeProductivity = 75000000m,
        },
        new UpgradeData
        {
            upgradeName = "Galactic sushi",
            upgrareIndex = 36,
            //upgradeIcon =  ,
            upgradeBuyPrice = 20000000000000000,
            priceIncrease = 1.15m,
            upgradeProductivity = 100000000m,
        },
        new UpgradeData
        {
            upgradeName = "Univers sushi",
            upgrareIndex = 37,
            //upgradeIcon =  ,
            upgradeBuyPrice = 30000000000000000,
            priceIncrease = 1.15m,
            upgradeProductivity = 125000000m,
        },
        new UpgradeData
        {
            upgradeName = "Cyber sushi",
            upgrareIndex = 38,
            //upgradeIcon =  ,
            upgradeBuyPrice = 50000000000000000,
            priceIncrease = 1.15m,
            upgradeProductivity = 150000000m,
        },
        new UpgradeData
        {
            upgradeName = "Sushi matrix",
            upgrareIndex = 39,
            //upgradeIcon =  ,
            upgradeBuyPrice = 150000000000000000,
            priceIncrease = 1.15m,
            upgradeProductivity = 300000000m,
        },
        new UpgradeData
        {
            upgradeName = "Sushi GOD",
            upgrareIndex = 40,
            //upgradeIcon =  ,
            upgradeBuyPrice = 1000000000000000000,
            priceIncrease = 1.15m,
            upgradeProductivity = 1000000000m,
        },
    };
}
