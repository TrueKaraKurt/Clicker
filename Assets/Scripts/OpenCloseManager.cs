using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCloseManager : MonoBehaviour
{
    [SerializeField] private GameObject _clickPanel;
    [SerializeField] private GameObject _upgradePanel;
    [SerializeField] private GameObject _inGameMenuPanel;
    [SerializeField] private GameObject _cheatMenu;

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
    private void ToggleUpgradePanel()
    {
        if (_upgradePanel.activeSelf)
        {
            _upgradePanel.SetActive(false);
        }
        else
        {
            _upgradePanel.SetActive(true);
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
    public void ToggleKitUpgradePannel()
    {
        ToggleClickPanel();
        ToggleUpgradePanel();
        ToggleInGameMenuPanel();
    }

    public void ToggleCheatMenu() 
    {
        ToggleClickPanel();
        ToggleSodomyMenu();
        ToggleInGameMenuPanel();
    }
}
