using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AutoAddit : MonoBehaviour
{
    [SerializeField] private Text _sushiCountDisplay;
    Incrementer incrementer;
    private void Start()
    {
        incrementer = new Incrementer();
        incrementer.LoadSushiCount();
    }

    private void Update()
    {
        _sushiCountDisplay.text =incrementer.GetSushiCount().ToString();
    }
    public void OnClickEvent()
    {
        incrementer.IncreaseSushiCount();
    }


}
