using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileLauncher : MonoBehaviour
{
    [SerializeField] private Projectile _projectileGO;
    [SerializeField] private float _fireCadence = 1.0f;
    private float _lastTimeShoot = 0.0f;
    public Transform firePoint;

    public void SpawnProjectile()
    {
        if (!_projectileGO) { return; }
        if (_lastTimeShoot + _fireCadence > Time.time) { return; }

        _lastTimeShoot = Time.time;
        Instantiate(_projectileGO, firePoint.position, firePoint.rotation);
    
    }
}
