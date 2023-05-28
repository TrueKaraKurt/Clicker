using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class FloatingTextController : MonoBehaviour
{
    [SerializeField] private int _poolCount = 30;
    [SerializeField] private bool _autoExpand = false;
    [SerializeField] private FloatingText _floatingTextPrefab;

    [SerializeField] private Transform _parent;

    private ObjPool<FloatingText> _pool;

    private void Awake()
    {
        Incrementer.OnSushiClick += CreateFloatingText;
    }

    private void Start()
    {
        _pool = new ObjPool<FloatingText>(_floatingTextPrefab, _poolCount, _parent);
        _pool.isAutoExpandble = _autoExpand;
    }

    private void OnDestroy()
    {
        Incrementer.OnSushiClick -= CreateFloatingText;
    }


    private void CreateFloatingText(decimal value, bool isCrit)
    {
        float xPos = Random.Range(-250f, 250f);
        float yPos = Random.Range(-250f, 250f);
        Vector3 pos = new Vector3(xPos, yPos, 0);

        FloatingText floatText = _pool.GetFreeElement();
        floatText.transform.localPosition = pos;

        floatText.ActivateFloatText(value, isCrit);
    }
}
