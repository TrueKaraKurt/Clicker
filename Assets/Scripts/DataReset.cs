using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DataReset : MonoBehaviour
{

    public static event Action OnDataReset;
    public void ResetAllData()
    {
        OnDataReset?.Invoke();
        Incrementer.Instance.ResetSushiCount();
        AutoAddit.Instance.ResetUpgrades();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
