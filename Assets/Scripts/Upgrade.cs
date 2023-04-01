using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct UpgradeData
{
    public string upgradeName;
    public int upgrareIndex;
    public Sprite upgradeIcon;
    public int upgradeBuyPrice;
    public float priceIncrease;
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
            priceIncrease = 1.1f,
            upgradeProductivity = 0.1f,
        },

        new UpgradeData
        {
            upgradeName = "Chinese worker",
            upgrareIndex = 1,
            //upgradeIcon =  ,
            upgradeBuyPrice = 250,
            priceIncrease = 1.1f,
            upgradeProductivity = 2.5f,
        },

        new UpgradeData
        {
            upgradeName = "Sushi restaurant",
            upgrareIndex = 2,
            //upgradeIcon =  ,
            upgradeBuyPrice = 3300,
            priceIncrease = 1.1f,
            upgradeProductivity = 30f,
        },

        new UpgradeData
        {
            upgradeName = "Sushi factory",
            upgrareIndex = 3,
            //upgradeIcon =  ,
            upgradeBuyPrice = 55000,
            priceIncrease = 1.1f,
            upgradeProductivity = 50f,
        },
    };
}
