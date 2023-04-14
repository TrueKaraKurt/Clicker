using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class KnifeManager : MonoBehaviour
{
    [SerializeField] private GameObject _prefab;
    [SerializeField] private Transform _parentPrefab;

    private int _currentNumberOfKnifes;
    private float _radius = 300f;
    private float _distanceToCenter;

    private List<GameObject> _flyingKnifes;

    private void Start()
    {
        _flyingKnifes = new List<GameObject>();


        KnifeCreate();
        _distanceToCenter = Vector3.Distance(_flyingKnifes[1].transform.localPosition, Vector3.zero);
        Debug.Log(_distanceToCenter);
        KnifeBaseRotate();
        StartCoroutine(KnifePing());
    }
    public void KnifeCreate()
    {
        _currentNumberOfKnifes = AutoAddit.Instance.PassKnifeCount();
        for (int i = 0; i < _currentNumberOfKnifes; i++)
        {
            float angle = 0f;
            Vector3 knifePos = CalcCoordinatesOnCircle(i, ref angle);
            GameObject tempObj = Instantiate(_prefab, _parentPrefab); //knifePos, Quaternion.identity,
            tempObj.transform.localPosition = knifePos;
            tempObj.transform.Rotate(new Vector3(0, 0, -angle));
            _flyingKnifes.Add(tempObj);
        }
        
    }

    private Vector3 CalcCoordinatesOnCircle(int index, ref float angle)
    {
        Vector3 temp = Vector3.zero;

        float circleposition = (float)index / (float)_currentNumberOfKnifes;
        temp.x = Mathf.Sin(circleposition * Mathf.PI * 2.0f) * _radius;
        temp.y = Mathf.Cos(circleposition * Mathf.PI * 2.0f) * _radius;

        //Debug.Log(Vector3.Angle(Vector3.up - Vector3.zero, temp - Vector3.zero) + index);
        angle =  360 - Quaternion.FromToRotation(Vector3.up, (temp - Vector3.zero) - (Vector3.up - Vector3.zero)).eulerAngles.z;
        return temp;
    }

    private void KnifeBaseRotate()
    {
        _parentPrefab.DORotate(new Vector3(0,0,360), 36f, RotateMode.FastBeyond360)
            .SetEase(Ease.Linear)
            .SetLoops(-1);
    }
    private IEnumerator KnifePing(int index = 0)
    {
        yield return new WaitForSeconds(.1f);
        Sequence mySequence = DOTween.Sequence();
        Transform knifeTransform = _flyingKnifes[index].transform;

        Vector3 startPos = knifeTransform.localPosition;
        Vector3 parentPos = Vector3.zero;
        Debug.Log(knifeTransform.name + " autor before");
        mySequence.Append(knifeTransform.DOLocalMove((Vector3.zero - _flyingKnifes[index].transform.localPosition).normalized * (-_radius + 40), .5f)
            .OnComplete(() =>
            {
                    _flyingKnifes[index - 1].transform.DOLocalMove((Vector3.zero - _flyingKnifes[index - 1].transform.localPosition).normalized * -_radius, .5f);
                if (index == _flyingKnifes.Count -1)
                {
                    _flyingKnifes[_flyingKnifes.Count - 1].transform.DOLocalMove((Vector3.zero - _flyingKnifes[_flyingKnifes.Count - 1].transform.localPosition).normalized * -_radius, .5f);
                }
            }))
            .AppendInterval(.1f * _flyingKnifes.Count - .5f).SetLoops(-1);

        if (index + 1 < _flyingKnifes.Count)
        {

            StartCoroutine(KnifePing(++index));
        }
    }
}
