using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LifeSystem : MonoBehaviour, IHitable
{

    [SerializeField] private UnityEvent<int> _onHitEvent = new UnityEvent<int> ();
    [SerializeField] private UnityEvent _onNoHpEvent = new UnityEvent();
    [SerializeField] private ETeam _team = ETeam.None;
    [SerializeField] private int _maxHP = 1;
    private int _currenHP = 0;
    void Start()
    {
        _currenHP = _maxHP;
    }

    public void Hit(int value)
    {
        _currenHP = Mathf.Max(_currenHP - value, 0);
        _onHitEvent?.Invoke(_currenHP);

        if (_currenHP == 0)
        {
            _onNoHpEvent?.Invoke();
        }

    }

    public ETeam GetTeam()
    {
        return _team;
    }
}
