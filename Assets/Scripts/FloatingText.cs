using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FloatingText : MonoBehaviour
{
    private decimal _textValue;
    [SerializeField] private TextMeshProUGUI _displayedText;
    [SerializeField] private CanvasGroup _imageDisplay;
    public void ActivateFloatText( decimal value, bool isCrit)
    {
        SetValue(value);

        DisplayText();
        TextAnimation(isCrit);

    }
    private void SetValue(decimal value)
    {
        _textValue = value;
    }

    private void DisplayText()
    {
        _displayedText.text = _textValue.ToString();
    }

    private void TextAnimation(bool isCrit)
    {
        if (isCrit)
        {
            _displayedText.faceColor = Color.red;
        }
        transform.DOLocalMoveY(transform.localPosition.y + 200, 2);
        _imageDisplay.DOFade(0, 2)
            .OnComplete(()=>
            {
                gameObject.SetActive(false);
                _imageDisplay.DOFade(1, 0);
                _displayedText.faceColor = Color.white;
            });
    }
}
