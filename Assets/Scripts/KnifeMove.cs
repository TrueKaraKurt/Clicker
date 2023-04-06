using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeMove : MonoBehaviour
{
    private void Start()
    {
        KnifeAnimation(() => Debug.Log("pass"));
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            KnifeAnimation(() => Debug.Log("pay respect"));
        }
    }

    /*private void KnifeAnimation()
    {
        transform.DOLocalMove(Vector3.zero, 1)
        .OnComplete(() => transform.DOLocalMove(new Vector3(0, 300, 0), 1).OnComplete(()=> {
            KnifeAnimation();
            Debug.Log("pass");
        })).SetEase(Ease.OutQuint).OnUpdate(()=> Debug.Log(transform.localPosition.y));
    }*/
    private void KnifeAnimation(Action callback)
    {
        transform.DOLocalMove(Vector3.zero, 1)
        .OnComplete(()=> callback?.Invoke());
    }
}
