using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Hitter : MonoBehaviour
{
    [SerializeField] UnityEvent onHitEvent = new UnityEvent();
    [SerializeField] int _baseDamage = 1;
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<IHitable>(out IHitable hitable))
        {
            hitable.Hit(_baseDamage);
            onHitEvent?.Invoke();
        }
    }
}
