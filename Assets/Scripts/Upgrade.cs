using System;
using System.Collections;
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
    public float upgradeProductivity;
}
public class Upgrade
{
    public static List<UpgradeData> updates = new List<UpgradeData>()
    {
        new UpgradeData
        {
            upgradeName = "Knife",
            upgrareIndex = 0,
            //upgradeIcon =  ,
            upgradeBuyPrice = 10,
            priceIncrease = 1.1m,
            upgradeProductivity = 0.1f,
        },
        new UpgradeData
        {
            upgradeName = "Chinese worker",
            upgrareIndex = 1,
            //upgradeIcon =  ,
            upgradeBuyPrice = 100,
            priceIncrease = 1.1m,
            upgradeProductivity = 0.3f,
        },
        new UpgradeData
        {
            upgradeName = "Sushi master",
            upgrareIndex = 2,
            //upgradeIcon =  ,
            upgradeBuyPrice = 500,
            priceIncrease = 1.1m,
            upgradeProductivity = 0.5f,
        },
        new UpgradeData
        {
            upgradeName = "Sushi O-Matic",
            upgrareIndex = 3,
            //upgradeIcon =  ,
            upgradeBuyPrice = 2000,
            priceIncrease = 1.1m,
            upgradeProductivity = 1f,
        },
        new UpgradeData
        {
            upgradeName = "Sushi restaurant",
            upgrareIndex = 4,
            //upgradeIcon =  ,
            upgradeBuyPrice = 10000,
            priceIncrease = 1.1m,
            upgradeProductivity = 3f,
        },
        new UpgradeData
        {
            upgradeName = "Small sushi factory",
            upgrareIndex = 5,
            //upgradeIcon =  ,
            upgradeBuyPrice = 50000,
            priceIncrease = 1.1m,
            upgradeProductivity = 10f,
        },
        new UpgradeData
        {
            upgradeName = "Medium sushi factory",
            upgrareIndex = 6,
            //upgradeIcon =  ,
            upgradeBuyPrice = 200000,
            priceIncrease = 1.1m,
            upgradeProductivity = 20f,
        },
        new UpgradeData
        {
            upgradeName = "Big sushi factory",
            upgrareIndex = 7,
            //upgradeIcon =  ,
            upgradeBuyPrice = 500000,
            priceIncrease = 1.1m,
            upgradeProductivity = 40f,
        },
        new UpgradeData
        {
            upgradeName = "Sushi cloning machine",
            upgrareIndex = 8,
            //upgradeIcon =  ,
            upgradeBuyPrice = 1500000,
            priceIncrease = 1.1m,
            upgradeProductivity = 100f,
        },
        new UpgradeData
        {
            upgradeName = "Sushi cloning machine",
            upgrareIndex = 9,
            //upgradeIcon =  ,
            upgradeBuyPrice = 1500000,
            priceIncrease = 1.1m,
            upgradeProductivity = 100f,
        },
        new UpgradeData
        {
            upgradeName = "Sushi research institute",
            upgrareIndex = 10,
            //upgradeIcon =  ,
            upgradeBuyPrice = 5000000,
            priceIncrease = 1.1m,
            upgradeProductivity = 300f,
        },
        new UpgradeData
        {
            upgradeName = "Electton sushi",
            upgrareIndex = 11,
            //upgradeIcon =  ,
            upgradeBuyPrice = 15000000,
            priceIncrease = 1.1m,
            upgradeProductivity = 800f,
        },
        new UpgradeData
        {
            upgradeName = "Atomic sushi",
            upgrareIndex = 12,
            //upgradeIcon =  ,
            upgradeBuyPrice = 30000000,
            priceIncrease = 1.1m,
            upgradeProductivity = 1500f,
        },
        new UpgradeData
        {
            upgradeName = "Sushi Volcano",
            upgrareIndex = 13,
            //upgradeIcon =  ,
            upgradeBuyPrice = 100000000,
            priceIncrease = 1.1m,
            upgradeProductivity = 3000f,
        },
        new UpgradeData
        {
            upgradeName = "Earthquake sushi",
            upgrareIndex = 14,
            //upgradeIcon =  ,
            upgradeBuyPrice = 300000000,
            priceIncrease = 1.1m,
            upgradeProductivity = 5000f,
        },
        new UpgradeData
        {
            upgradeName = "Sushi tsunami",
            upgrareIndex = 15,
            //upgradeIcon =  ,
            upgradeBuyPrice = 1000000000,
            priceIncrease = 1.1m,
            upgradeProductivity = 10000f,
        },
        new UpgradeData
        {
            upgradeName = "Synthetic sushi",
            upgrareIndex = 16,
            //upgradeIcon =  ,
            upgradeBuyPrice = 2500000000,
            priceIncrease = 1.1m,
            upgradeProductivity = 20000f,
        },
        new UpgradeData
        {
            upgradeName = "Genetic sushi",
            upgrareIndex = 17,
            //upgradeIcon =  ,
            upgradeBuyPrice = 10000000000,
            priceIncrease = 1.1m,
            upgradeProductivity = 30000f,
        },
        new UpgradeData
        {
            upgradeName = "Sushi cyborg",
            upgrareIndex = 18,
            //upgradeIcon =  ,
            upgradeBuyPrice = 20000000000,
            priceIncrease = 1.1m,
            upgradeProductivity = 50000f,
        },
        new UpgradeData
        {
            upgradeName = "Alient sushi",
            upgrareIndex = 19,
            //upgradeIcon =  ,
            upgradeBuyPrice = 40000000000,
            priceIncrease = 1.1m,
            upgradeProductivity = 75000f,
        },
        new UpgradeData
        {
            upgradeName = "Alient sushi Lab",
            upgrareIndex = 20,
            //upgradeIcon =  ,
            upgradeBuyPrice = 60000000000,
            priceIncrease = 1.1m,
            upgradeProductivity = 100000f,
        },
        new UpgradeData
        {
            upgradeName = "Alient sushi tech",
            upgrareIndex = 21,
            //upgradeIcon =  ,
            upgradeBuyPrice = 100000000000,
            priceIncrease = 1.1m,
            upgradeProductivity = 150000f,
        },
        new UpgradeData
        {
            upgradeName = "Alient sushi AI",
            upgrareIndex = 22,
            //upgradeIcon =  ,
            upgradeBuyPrice = 250000000000,
            priceIncrease = 1.1m,
            upgradeProductivity = 300000f,
        },
        new UpgradeData
        {
            upgradeName = "Nano sushi",
            upgrareIndex = 23,
            //upgradeIcon =  ,
            upgradeBuyPrice = 500000000000,
            priceIncrease = 1.1m,
            upgradeProductivity = 500000f,
        },
        new UpgradeData
        {
            upgradeName = "Molecular sushi",
            upgrareIndex = 24,
            //upgradeIcon =  ,
            upgradeBuyPrice = 1000000000000,
            priceIncrease = 1.1m,
            upgradeProductivity = 750000f,
        },
        new UpgradeData
        {
            upgradeName = "Virus sushi",
            upgrareIndex = 25,
            //upgradeIcon =  ,
            upgradeBuyPrice = 1500000000000,
            priceIncrease = 1.1m,
            upgradeProductivity = 1000000f,
        },
        new UpgradeData
        {
            upgradeName = "Proto sushi",
            upgrareIndex = 26,
            //upgradeIcon =  ,
            upgradeBuyPrice = 3000000000000,
            priceIncrease = 1.1m,
            upgradeProductivity = 1500000f,
        },
        new UpgradeData
        {
            upgradeName = "Synaptic sushi",
            upgrareIndex = 27,
            //upgradeIcon =  ,
            upgradeBuyPrice = 7500000000000,
            priceIncrease = 1.1m,
            upgradeProductivity = 3000000f,
        },
        new UpgradeData
        {
            upgradeName = "Hydrogen sushi",
            upgrareIndex = 28,
            //upgradeIcon =  ,
            upgradeBuyPrice = 20000000000000,
            priceIncrease = 1.1m,
            upgradeProductivity = 5000000f,
        },
        new UpgradeData
        {
            upgradeName = "Uranium sushi",
            upgrareIndex = 29,
            //upgradeIcon =  ,
            upgradeBuyPrice = 50000000000000,
            priceIncrease = 1.1m,
            upgradeProductivity = 7500000f,
        },
        new UpgradeData
        {
            upgradeName = "Plutonium sushi",
            upgrareIndex = 30,
            //upgradeIcon =  ,
            upgradeBuyPrice = 100000000000000,
            priceIncrease = 1.1m,
            upgradeProductivity = 10000000f,
        },
        new UpgradeData
        {
            upgradeName = "Space sushi factory",
            upgrareIndex = 31,
            //upgradeIcon =  ,
            upgradeBuyPrice = 300000000000000,
            priceIncrease = 1.1m,
            upgradeProductivity = 15000000f,
        },
        new UpgradeData
        {
            upgradeName = "Sushi colonizator",
            upgrareIndex = 32,
            //upgradeIcon =  ,
            upgradeBuyPrice = 1000000000000000,
            priceIncrease = 1.1m,
            upgradeProductivity = 20000000f,
        },
        new UpgradeData
        {
            upgradeName = "Sushi star",
            upgrareIndex = 33,
            //upgradeIcon =  ,
            upgradeBuyPrice = 2000000000000000,
            priceIncrease = 1.1m,
            upgradeProductivity = 30000000f,
        },
        new UpgradeData
        {
            upgradeName = "sushi force",
            upgrareIndex = 34,
            //upgradeIcon =  ,
            upgradeBuyPrice = 5000000000000000,
            priceIncrease = 1.1m,
            upgradeProductivity = 50000000f,
        },
        new UpgradeData
        {
            upgradeName = "Dark sushi",
            upgrareIndex = 35,
            //upgradeIcon =  ,
            upgradeBuyPrice = 10000000000000000,
            priceIncrease = 1.1m,
            upgradeProductivity = 75000000f,
        },
        new UpgradeData
        {
            upgradeName = "Galactic sushi",
            upgrareIndex = 36,
            //upgradeIcon =  ,
            upgradeBuyPrice = 20000000000000000,
            priceIncrease = 1.1m,
            upgradeProductivity = 100000000f,
        },
        new UpgradeData
        {
            upgradeName = "Univers sushi",
            upgrareIndex = 37,
            //upgradeIcon =  ,
            upgradeBuyPrice = 30000000000000000,
            priceIncrease = 1.1m,
            upgradeProductivity = 125000000f,
        },
        new UpgradeData
        {
            upgradeName = "Cyber sushi",
            upgrareIndex = 38,
            //upgradeIcon =  ,
            upgradeBuyPrice = 50000000000000000,
            priceIncrease = 1.1m,
            upgradeProductivity = 150000000f,
        },
        new UpgradeData
        {
            upgradeName = "Sushi matrix",
            upgrareIndex = 39,
            //upgradeIcon =  ,
            upgradeBuyPrice = 150000000000000000,
            priceIncrease = 1.1m,
            upgradeProductivity = 300000000f,
        },
        new UpgradeData
        {
            upgradeName = "Sushi GOD",
            upgrareIndex = 40,
            //upgradeIcon =  ,
            upgradeBuyPrice = 1000000000000000000,
            priceIncrease = 1.1m,
            upgradeProductivity = 1000000000f,
        },
    };
}
