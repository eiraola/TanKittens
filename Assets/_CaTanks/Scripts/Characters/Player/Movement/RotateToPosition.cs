using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToPosition : MonoBehaviour
{
    private Vector3 _currentDirection = Vector3.zero;
    private void Start()
    {
        
    }
    public void SetCurrentDirection(Vector3 newPos)
    {
        _currentDirection = (newPos - transform.position).normalized;
        _currentDirection.y = 0.0f;
    }
    private void Update()
    {
        transform.LookAt( _currentDirection + transform.position);
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawSphere(_currentDirection + transform.position, 0.1f);
    }
}
