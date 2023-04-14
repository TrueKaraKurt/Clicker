using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife : MonoBehaviour
{
    [SerializeField] private GameObject _prefab;

    public static event Action<GameObject> OnUpgradeBuying;


    public void UpgradeBuying()
    {
        OnUpgradeBuying?.Invoke(_prefab);
    }
}
