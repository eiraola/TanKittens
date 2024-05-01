using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileLauncher : MonoBehaviour
{
    [SerializeField] private Projectile _projectileGO;
    public Transform firePoint;

    public void SpawnProjectile()
    {
        if (!_projectileGO) { return; } 
        Instantiate(_projectileGO, firePoint.position, firePoint.rotation);
    
    }
}
