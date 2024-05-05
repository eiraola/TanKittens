using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileLauncher : MonoBehaviour
{
    [SerializeField] private Hitter _projectileGO;
    [SerializeField] private float _fireCadence = 1.0f;
    [SerializeField] private ETeam _team = ETeam.None;
    private float _lastTimeShoot = 0.0f;
    public Transform firePoint;

    public void SpawnProjectile()
    {
        if (!_projectileGO) { return; }
        if (_lastTimeShoot + _fireCadence > Time.time) { return; }

        _lastTimeShoot = Time.time;
        Hitter hitter = Instantiate(_projectileGO, firePoint.position, firePoint.rotation);
        hitter.team = _team;
    
    }
}
