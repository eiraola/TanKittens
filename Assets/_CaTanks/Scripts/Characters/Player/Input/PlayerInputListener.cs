using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.XR;
public class PlayerInputListener : MonoBehaviour
{
    [SerializeField] UnityEvent<Vector2> OnMovementInputEvent = new UnityEvent<Vector2>();
    [SerializeField] UnityEvent OnFirePressedEvent = new UnityEvent();
    [SerializeField] UnityEvent OnFireReleasedEvent = new UnityEvent();

    public void ReadMovementAction(InputAction.CallbackContext context)
    {
        if (context.performed || context.canceled)
        {
            OnMovementInputEvent.Invoke(context.ReadValue<Vector2>());
        }
    }
    public void OnFireButtonAction(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            OnFirePressedEvent.Invoke();
        }

        if (context.canceled)
        {
            OnFireReleasedEvent.Invoke();
        }
    }
}
