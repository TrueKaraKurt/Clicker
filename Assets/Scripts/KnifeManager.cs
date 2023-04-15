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
    private Coroutine _pingTiming;
    private List<Sequence> _standsForKnives;
    private List<Tweener> _knifesAnimation;

    private List<GameObject> _flyingKnifes;

    private void Awake()
    {
        _flyingKnifes = new List<GameObject>();
        _standsForKnives = new List<Sequence>();
        AutoAddit.OnfirstKnifeCreate += KnifeCreate;
        AutoAddit.OnKnifeUpgradeBuying += AddKnife;
        DataReset.OnDataReset += KillAllSequence;
    }
    private void Start()
    {
        KnifeBaseRotate();
        _pingTiming = StartCoroutine(KnifePing());
    }
    private void OnDestroy()
    {
        AutoAddit.OnfirstKnifeCreate -= KnifeCreate;
        AutoAddit.OnKnifeUpgradeBuying -= AddKnife;
        DataReset.OnDataReset -= KillAllSequence;
    }
    public void KnifeCreate(int numOfKnifes)
    {
        _currentNumberOfKnifes = numOfKnifes;
        for (int i = 0; i < _currentNumberOfKnifes; i++)
        {
            InitKnifeCreate();
        }

        for (int i = 0; i < _currentNumberOfKnifes; i++)
        {
            SetCoordinatesOnListObject(i);
        }
        _pingTiming = StartCoroutine(KnifePing());
    }
    private void AddKnife()
    {
        _currentNumberOfKnifes++;
        KillAllSequence();
        InitKnifeCreate();
        RecalculateCoordinatesObjects();
        _pingTiming = StartCoroutine(KnifePing());
    }

    private void RecalculateCoordinatesObjects()
    {
        for (int i = 0; i < _currentNumberOfKnifes; i++)
        {
            SetCoordinatesOnListObject(i);
        }

    }
    private void InitKnifeCreate()
    {
        GameObject tempObj = Instantiate(_prefab, _parentPrefab);
        _flyingKnifes.Add(tempObj);
    }
    private void SetCoordinatesOnListObject(int index)
    {
        float angle = 0f;
        Vector3 knifePos = CalcCoordinatesOnCircle(index, ref angle);
        _flyingKnifes[index].transform.localPosition = knifePos;
        _flyingKnifes[index].transform.localRotation = Quaternion.Euler(new Vector3(0, 0, -angle));
    }

    private Vector3 CalcCoordinatesOnCircle(int index, ref float angle)
    {
        Vector3 temp = Vector3.zero;

        float circleposition = (float)index / (float)_currentNumberOfKnifes;
        temp.x = Mathf.Sin(circleposition * Mathf.PI * 2.0f) * _radius;
        temp.y = Mathf.Cos(circleposition * Mathf.PI * 2.0f) * _radius;

        angle =  360 - Quaternion.FromToRotation(Vector3.up, (temp - Vector3.zero) - (Vector3.up - Vector3.zero)).eulerAngles.z;
        return temp;
    }
    private void KnifeBaseRotate()
    {
        _parentPrefab.DORotate(new Vector3(0,0,-360), 180f, RotateMode.FastBeyond360)
            .SetEase(Ease.Linear)
            .SetLoops(-1);
    }
    private IEnumerator KnifePing(int index = 0)
    {
        yield return new WaitForSeconds(1f);
        if (_flyingKnifes.Count != 0)
        {
            float cycleTime = 10f;
            if (_flyingKnifes.Count > 10)
            {
                cycleTime = _flyingKnifes.Count * 1f - 5f;
            }

            Sequence mySequence = DOTween.Sequence();
            _standsForKnives.Add(mySequence);
            Transform knifeTransform = _flyingKnifes[index].transform;

            Vector3 startPos = knifeTransform.localPosition;
            Vector3 parentPos = Vector3.zero;

            mySequence.Append(knifeTransform.DOLocalMove((Vector3.zero - _flyingKnifes[index].transform.localPosition).normalized * (-_radius + 40), 5f)
                .OnComplete(() =>
                {
                   _flyingKnifes[index - 1].transform.DOLocalMove((Vector3.zero - _flyingKnifes[index - 1].transform.localPosition).normalized * -_radius, 5f);
                    if (index == _flyingKnifes.Count - 1)
                    {
                        _flyingKnifes[_flyingKnifes.Count - 1].transform.DOLocalMove((Vector3.zero - _flyingKnifes[_flyingKnifes.Count - 1].transform.localPosition).normalized * -_radius, 5f);
                    }
                }))
                .AppendInterval(cycleTime).SetLoops(-1);

            if (index + 1 < _flyingKnifes.Count)
            {
                _pingTiming = StartCoroutine(KnifePing(++index));
            }
        }
    }

    public void KillAllSequence()
    {
        StopCoroutine(_pingTiming);

        foreach (var item in _flyingKnifes)
        {
            DOTween.Kill(item.transform);
        }
        foreach (var item in _standsForKnives)
        {
            item.Kill();
        }

        if (DOTween.TotalActiveTweens() > 0)
        {
            List<Tween> tweens = DOTween.PausedTweens();
            if (tweens == null)
            {
                return;
            }
            tweens.AddRange(DOTween.PlayingTweens());
            for (int i = 0; i < tweens.Count; i++)
            {
                var tween = tweens[i];
                if (tween != null && tween.target is GameObject target && target.scene == gameObject.scene)
                    tween.Kill();
            }
        }
    }
}
