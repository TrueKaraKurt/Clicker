using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SushiAnimation : MonoBehaviour
{
    private Vector3 _scaleFrom;
    private Vector3 _scaleTo;
    private void Awake()
    {
        _scaleFrom = transform.localScale;
        _scaleTo = _scaleFrom * 0.9f;
    }

    public void SushiClickAnimation()
    {
        transform.DOScale(_scaleTo, 0.1f)
            .OnComplete(()=> transform.DOScale(_scaleFrom, 0.1f));
    }
}
