using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ScreenFader : MonoBehaviour
{
    [SerializeField] private Image _blackScreen;
    private Action _finishFade = null;
    private bool _isFading = false;

    private void DoFinishFadeIn()
    {
        _blackScreen.enabled = false;
        DoFinishAction();
    }

    private void DoFinishFadeOut()
    {
        _blackScreen.enabled = true;
        DoFinishAction();
    }

    private void DoFinishAction()
    {
        _isFading = false;
        if (_finishFade == null)
        {
            return;
        }
        _finishFade();
        _finishFade = null;
    }

    public void SetInitMode(bool faded) {
        if (faded)
        {
            _blackScreen.enabled = true;
            _blackScreen.GetComponent<CanvasGroup>().alpha = 1.0f;
            return;
        }
        _blackScreen.enabled = false;
        _blackScreen.GetComponent<CanvasGroup>().alpha = 0.0f;
    }
    public void FadeIn(float timeToFade, Action action = null)
    {
        if (_isFading)
        {
            return;
        }
        _blackScreen.enabled = true;
        _isFading = true;
        _finishFade = action;
        Sequence sequence = DOTween.Sequence();

        sequence.Insert(0, _blackScreen.DOFade(0.0f, timeToFade));
        sequence.onComplete = DoFinishFadeIn;
    }

    public void FadeOut(float timeToFade, Action action = null)
    {
        if (_isFading)
        {
            return;
        }
        _blackScreen.enabled = true;
        _isFading = true;
        _finishFade = action;
        Sequence sequence = DOTween.Sequence();

        sequence.Insert(0, _blackScreen.DOFade(1.0f, timeToFade));
        sequence.onComplete = DoFinishFadeOut;
    }
}
