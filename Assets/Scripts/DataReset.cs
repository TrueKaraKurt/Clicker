using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataReset : MonoBehaviour
{
    public void ResetAllData()
    {
        Incrementer.Instance.ResetSushiCount();
        AutoAddit.Instance.ResetUpgrades();
    }
}
