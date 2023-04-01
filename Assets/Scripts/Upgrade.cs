using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct UpgradeData
{
    public string upgradeName;
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
            //upgradeIcon =  ,
            upgradeBuyPrice = 10,
            priceIncrease = 1.4f,
            upgradeProductivity = 0.1f,
        },

        new UpgradeData
        {
            upgradeName = "Chinese worker",
            //upgradeIcon =  ,
            upgradeBuyPrice = 250,
            priceIncrease = 1.4f,
            upgradeProductivity = 2.5f,
        },

        new UpgradeData
        {
            upgradeName = "Sushi restaurant",
            //upgradeIcon =  ,
            upgradeBuyPrice = 3300,
            priceIncrease = 1.4f,
            upgradeProductivity = 30f,
        },

        new UpgradeData
        {
            upgradeName = "Sushi factory",
            //upgradeIcon =  ,
            upgradeBuyPrice = 3300,
            priceIncrease = 1.4f,
            upgradeProductivity = 30f,
        },
    };
}
