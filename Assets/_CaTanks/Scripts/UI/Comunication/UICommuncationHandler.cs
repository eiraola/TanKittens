using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UICommuncationHandler : MonoBehaviour
{
    [SerializeField] private UICommunications _uiCommunications;
    [SerializeField] private UnityEvent<int> _onLifeValueChange = new UnityEvent<int>();

    private void Start()

    {
        _uiCommunications.onLifeChange.AddListener(RecieveLifeValue);
    }

    public void SendLifeValue(int value)
    {
        _uiCommunications.onLifeChange?.Invoke(value);
    }

    public void RecieveLifeValue(int value)
    {
        _onLifeValueChange?.Invoke(value);
    }
}
