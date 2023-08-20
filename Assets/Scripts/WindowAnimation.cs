using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowAnimation : MonoBehaviour
{
    private Vector3 _startWindowPosition;
    private Vector3 _endWindowPosition;

    private void Awake()
    {
        _startWindowPosition = transform.localPosition;
         _endWindowPosition = new Vector3(0, transform.localPosition.y, 0);
    }
    public void OnOpenAnimation()
    {
        transform.DOLocalMove(_endWindowPosition, .75f)
            .SetEase(Ease.InOutCubic);
    }
    public void OnCloseAnimation()
    {
        transform.DOLocalMove(_startWindowPosition, .75f)
            .SetEase(Ease.InOutCubic);
    }
}
