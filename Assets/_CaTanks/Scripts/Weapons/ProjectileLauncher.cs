using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileLauncher : MonoBehaviour
{
    [SerializeField] Projectile _projectileGO;
    [SerializeField] Transform _firePoint;

    public void SpawnProjectile()
    {
        if (!_projectileGO) { return; } 
        Instantiate(_projectileGO, _firePoint.position, _firePoint.rotation);
    
    }
}
