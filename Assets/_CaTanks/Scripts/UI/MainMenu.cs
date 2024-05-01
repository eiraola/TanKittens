using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private ScreenFader _screenFader;
    [SerializeField] private IntroUI _introUI;

    private void Start()
    {
        _screenFader.SetInitMode(true);
        _screenFader.FadeIn(1.0f, StartIntro);
    }
    private void StartIntro() {
        _introUI.OpeningSequence();
    }
}
