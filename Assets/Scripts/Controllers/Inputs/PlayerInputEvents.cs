using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[CreateAssetMenu(menuName ="Player Input")]
public class PlayerInputEvents : ScriptableObject, PlayerInputSystem.IDefaultActions, PlayerInputSystem.IPauseMenuActions
{
    private PlayerInputSystem m_PlayerInput;

    private void OnEnable()
    {
        if(m_PlayerInput == null)
        {
            Debug.Log("NewInput");
            m_PlayerInput = new PlayerInputSystem();

            m_PlayerInput.Default.SetCallbacks(this);

            m_PlayerInput.Default.Enable();
        }
    }

    public event Action<Vector2> MoveEvent;
    public event Action DashEvent;
    public event Action PrimaryFirePressedEvent;
    public event Action PrimaryFireReleasedEvent;
    public event Action SecondaryFirePressedEvent;
    public event Action SecondaryFireReleasedEvent;
    public event Action PauseEvent;
    public event Action InteractEvent;
    public event Action ReturnEvent;

    public void OnMove(InputAction.CallbackContext context)
    {
        //Debug.Log($"Phase: {context.phase}, Value: {context.ReadValue<Vector2>()}");
        MoveEvent?.Invoke(context.ReadValue<Vector2>());
    }

    public void OnDash(InputAction.CallbackContext context)
    {
        if(context.phase == InputActionPhase.Performed)
        {
            DashEvent?.Invoke();
        }
    }

    public void OnPrimaryFire(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            PrimaryFirePressedEvent?.Invoke();
        }
        else if(context.phase == InputActionPhase.Canceled)
        {
            PrimaryFireReleasedEvent?.Invoke();
        }
    }

    public void OnSecondaryFire(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            SecondaryFirePressedEvent?.Invoke();
        }
        else if (context.phase == InputActionPhase.Canceled)
        {
            SecondaryFireReleasedEvent?.Invoke();
        }
    }

    public void OnInteract(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            InteractEvent?.Invoke();
        }
    }

    public void OnPause(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            PauseEvent?.Invoke();
        }
    }

    public void OnReturn(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            ReturnEvent?.Invoke();
        }
    }
}
