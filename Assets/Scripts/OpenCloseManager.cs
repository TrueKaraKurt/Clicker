using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCloseManager : MonoBehaviour
{
    [SerializeField] private GameObject _clickPanel;
    [SerializeField] private GameObject _inGameMenuPanel;
    [SerializeField] private GameObject _cheatMenu;

    [SerializeField] private GameObject _upgradesMenu;
    [SerializeField] private GameObject _powerUpsMenu;


    private void OpenUpgradesMenu()
    {
        _upgradesMenu.SetActive(true);
    }
    private void CloseUpgradesMenu()
    {
        _upgradesMenu.SetActive(false);
    }
    private void OpenPowerUpsMenu()
    {
        _powerUpsMenu.SetActive(true);
    }
    private void ClosePowerUpsMenu()
    {
        _powerUpsMenu.SetActive(false);
    }

    private void ToggleClickPanel()
    {
        if (_clickPanel.activeSelf)
        {
            _clickPanel.SetActive(false);
        }
        else
        {
            _clickPanel.SetActive(true);
        }
    }
    private void ToggleInGameMenuPanel()
    {
        if (_inGameMenuPanel.activeSelf)
        {
            _inGameMenuPanel.SetActive(false);
        }
        else
        {
            _inGameMenuPanel.SetActive(true);
        }
    }
    private void ToggleSodomyMenu()
    {
        if (_cheatMenu.activeSelf)
        {
            _cheatMenu.SetActive(false);
        }
        else
        {
            _cheatMenu.SetActive(true);
        }
    }

    public void OnClickUpgradesButton()
    {
        OpenUpgradesMenu();
        ClosePowerUpsMenu();
    }
    public void OnClickPowerUpsButton()
    {
        OpenPowerUpsMenu();
        CloseUpgradesMenu();
    }

    public void ToggleCheatMenu() 
    {
        ToggleClickPanel();
        ToggleSodomyMenu();
        ToggleInGameMenuPanel();
    }
}
