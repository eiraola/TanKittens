using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToPosition : MonoBehaviour
{
    private Vector3 _currentDirection = Vector3.zero;
    public Transform transformObject;

    public void SetCurrentDirection(Vector3 newPos)
    {
        if (!transformObject)
        {
            return;
        }
        _currentDirection = (newPos - transformObject.position).normalized;
        _currentDirection.y = 0.0f;
    }

    private void Update()
    {
        LookToPosition();
    }

    private void LookToPosition()
    {
        if (!transformObject)
        {
            return;
        }
        transformObject.LookAt(_currentDirection + transformObject.position);
    }

}
