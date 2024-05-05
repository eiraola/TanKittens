using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UILifeChanger : MonoBehaviour
{
    [SerializeField] private List<Image> _hpImages = new List<Image> ();

    public void SetLifesValue(int value)
    {
        int index = 0;
        foreach (Image image in _hpImages)
        {
            if (index >= value)
            {
                image.gameObject.SetActive(false);
            }
            else
            {
                image.gameObject.SetActive(true);
            }
            index++;
        }
    }
}
