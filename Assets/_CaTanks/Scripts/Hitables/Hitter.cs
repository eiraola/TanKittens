using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Hitter : MonoBehaviour
{
    [SerializeField] private UnityEvent onHitEvent = new UnityEvent();
    [SerializeField] private int _baseDamage = 1;
    public ETeam team = ETeam.None;
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<IHitable>(out IHitable hitable))
        {
            if (hitable.GetTeam() == ETeam.None || hitable.GetTeam() == team)
            {
                return;
            }

            hitable.Hit(_baseDamage);
            onHitEvent?.Invoke();
        }
    }
}
