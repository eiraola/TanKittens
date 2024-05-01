using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Progress;

public class IntroUI : MonoBehaviour
{
    [SerializeField] private GameObject _mainTitle;
    [SerializeField] private GameObject _startPoint;
    [SerializeField] private GameObject _endPoint;
    [SerializeField] private CanvasGroup _menu;

    private void Start()
    {
        _mainTitle.transform.position = _startPoint.transform.position;
    }
    public void OpeningSequence()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Insert(0.0f, _mainTitle.transform.DOMoveY(_endPoint.transform.position.y, 1.5f));
        sequence.onComplete = FadeInMenu;
    }

    public void FadeInMenu()
    {
        Sequence sequence = DOTween.Sequence();
        sequence.Insert(0.0f, _menu.DOFade(1.0f, 0.5f));
    }
}
