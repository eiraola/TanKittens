using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroyer : MonoBehaviour
{
    [SerializeField] GameObject _destroyableGO;

    public void DestroyGO() {
        if (!_destroyableGO)
        {
            _destroyableGO = gameObject;
        }
        Destroy(_destroyableGO);
    }
}
