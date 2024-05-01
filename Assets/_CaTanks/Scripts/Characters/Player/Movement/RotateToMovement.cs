using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToMovement : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed = 1.0f;
    private Vector3 _currentDirection = Vector3.zero;
    public Transform transformObject;
    public void SetCurrentDirection(Vector3 newDir)
    {
        _currentDirection = newDir.normalized;
    }
    private void Update()
    {
        Rotate();
    }
    private void Rotate()
    {
        if (transformObject == null) { return; }

        float singleStep = _rotationSpeed * Time.deltaTime;
        Vector3 targetDirection = Vector3.RotateTowards(transformObject.forward, _currentDirection, singleStep, 0.0f);
        transformObject.LookAt(targetDirection + transformObject.position);
    }
}
