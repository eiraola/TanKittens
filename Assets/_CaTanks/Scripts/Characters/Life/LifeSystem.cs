using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LifeSystem : MonoBehaviour, IHitable
{

    [SerializeField] private UnityEvent<int> _onHitEvent = new UnityEvent<int> ();
    [SerializeField] private UnityEvent _onNoHpEvent = new UnityEvent();
    [SerializeField] private int _maxHP = 1;
    private int _currenHP = 0;
    void Start()
    {
        _currenHP = _maxHP;
    }

    public void Hit(int value)
    {
        _currenHP = Mathf.Max(_currenHP - value, 0);
        _onHitEvent?.Invoke(value);

        if (_currenHP == 0)
        {
            _onNoHpEvent?.Invoke();
        }

    }
}
