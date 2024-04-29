using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroyer : MonoBehaviour
{
    [SerializeField] GameObject _destroyableGO;
    void Start()
    {
        if (!_destroyableGO)
        {
            _destroyableGO = gameObject;
        }
    }

    public void DestroyGO() { 
        Destroy(gameObject);
    }
}
