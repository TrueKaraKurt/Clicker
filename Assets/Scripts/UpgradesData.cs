using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "UpgradesData", menuName = "UpgradeShop/UpgradesData")]
public class UpgradesData : ScriptableObject
{
    [SerializeField] private UpgradeData[] _upgradeData;
    public UpgradeData[] upgradeData => _upgradeData;
}
