using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToMovement : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed = 1.0f;
    private Vector3 _currentDirection = Vector3.zero;
    public void SetCurrentDirection(Vector3 newDir)
    {
        _currentDirection = newDir.normalized;
    }
    private void Update()
    {
        float singleStep = _rotationSpeed * Time.deltaTime;
        Vector3 targetDirection = Vector3.RotateTowards(transform.forward, _currentDirection, singleStep, 0.0f);
        transform.LookAt(targetDirection + transform.position);
    }
}
