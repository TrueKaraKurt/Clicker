using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgrButtonToggler : MonoBehaviour
{
    [SerializeField] private GameObject _upgradesButton;
    [SerializeField] private GameObject _powerUpsButton;

    private Color32 _activeColor;
    private Color32 _unactiveColor;

    private void Awake()
    {
        _activeColor = new Color32(150, 130, 210, 255);
        _unactiveColor = new Color32(130, 110, 210, 255);
        _upgradesButton.GetComponent<Image>().color = _activeColor;
        _powerUpsButton.GetComponent<Image>().color = _unactiveColor;
    }
    public void OnClickUpgradesButton()
    {
        _upgradesButton.transform.SetSiblingIndex(1);
        _powerUpsButton.transform.SetSiblingIndex(0);

        _upgradesButton.GetComponent<Image>().color = _activeColor;
        _powerUpsButton.GetComponent<Image>().color = _unactiveColor;
    }
    public void OnClickPowerUpsButton()
    {
        _powerUpsButton.transform.SetSiblingIndex(1);
        _upgradesButton.transform.SetSiblingIndex(0);

        _upgradesButton.GetComponent<Image>().color = _unactiveColor;
        _powerUpsButton.GetComponent<Image>().color = _activeColor;
    }
}
