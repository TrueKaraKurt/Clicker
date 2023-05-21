using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PersonalPowerUpsData : PrefabPersonalData
{
    [SerializeField] private int _prefabIndex;

    private string _powerUpsName;
    private decimal _powerUpsPrice;
    private decimal _priceIncriase;
    private int _powerUpsLevel;
    private string _powerUpsDescription;

    private decimal _currentBuyPrice;

    [SerializeField] private TextMeshProUGUI _displayedName;
    [SerializeField] private TextMeshProUGUI _displayedPrice;
    [SerializeField] private TextMeshProUGUI _displayedLevel;
    [SerializeField] private TextMeshProUGUI _displayedDescription;
}
