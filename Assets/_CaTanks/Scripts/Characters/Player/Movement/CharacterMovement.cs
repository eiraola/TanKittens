using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.Events;

public class CharacterMovement : MonoBehaviour
{

    [SerializeField] private CharacterController _characterController;
    [SerializeField] private float _speed = 1f;
    [SerializeField] private UnityEvent<Vector3> _onMovementDoneEvent = new UnityEvent<Vector3>();
    private Vector3 _desiredSpeed = Vector3.zero;
    private Vector3 _inputSpeed = Vector3.zero;

    public void SetInputSpeed(Vector2 newInputSpeed)
    {
        _inputSpeed.x = newInputSpeed.x;
        _inputSpeed.z = newInputSpeed.y;
    }
    private void Update()
    {
        _characterController.Move(_inputSpeed * _speed * Time.deltaTime);
        _onMovementDoneEvent.Invoke(_inputSpeed);
    }
}
