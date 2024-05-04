using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TransformTargeter : MonoBehaviour
{
    [SerializeField] private float _angle = 20.0f;
    [SerializeField] private string _targetGOTag = "Player";
    private Transform _target;

    public UnityEvent onTargetAquired = new UnityEvent();

    public Transform Target { 
        get
        {

            if (!_target)
            {
                _target = GameObject.FindGameObjectWithTag(_targetGOTag).transform;
            }
            return _target;
        }
        set => _target = value; }

    void Update()
    {
        CheckIfPlayerAquiered();
    }

    private void CheckIfPlayerAquiered()
    {
        if (Target == null) { return; }
        if (Vector3.Angle((_target.position - transform.position).normalized, transform.forward) < _angle)
        {
            onTargetAquired?.Invoke();
        }
    }
}
