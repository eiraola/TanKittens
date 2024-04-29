using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float _lifeTime = 2.0f;
    [SerializeField] private float _speed = 1f;
    private float _spawnTime = 0f;

    private void Start()
    {
        _spawnTime = Time.time;
    }

    protected virtual void Travel(float deltaTime)
    {
        transform.position += transform.forward * _speed * deltaTime;
    }

    protected virtual void CheckDestroyTime()
    {
        if ((_spawnTime + _lifeTime) < Time.time)
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        Travel(Time.deltaTime);
        CheckDestroyTime();
    }
}
