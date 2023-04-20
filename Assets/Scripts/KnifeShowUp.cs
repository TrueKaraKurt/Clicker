using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeShowUp : MonoBehaviour
{
    private CanvasGroup _knifeContainer;
    private void Start()
    {
        _knifeContainer = transform.GetComponent<CanvasGroup>();
        StartCoroutine(KnifeAppearOnStart());
    }
     private IEnumerator KnifeAppearOnStart() 
    {
        yield return new WaitForSeconds(7f);
        _knifeContainer.DOFade(1, 10f);
    }
}
