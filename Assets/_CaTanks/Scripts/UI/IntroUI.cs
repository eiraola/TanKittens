using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Progress;

public class IntroUI : MonoBehaviour
{
    [SerializeField] private GameObject _mainTitle;
    [SerializeField] private GameObject _centerPointRef;
    [SerializeField] private CanvasGroup _menu;

    private void Start()
    {
        OpeningSequence();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void OpeningSequence()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Insert(0.0f, _mainTitle.transform.DOMoveY(_centerPointRef.transform.position.y, 1.5f));
        sequence.onComplete = FadeInMenu;
       

    }

    public void FadeInMenu()
    {
        Sequence sequence = DOTween.Sequence();
        sequence.Insert(0.0f, _menu.DOFade(1.0f, 0.5f));
    }
}
