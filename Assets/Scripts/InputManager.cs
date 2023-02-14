using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    //ShipControl

    private Vector2 moveDirection = Vector2.zero;

    private float accelerationChange = 0f;

    private bool radarPressed;

    private bool shootPressed;

    //UIControl

    private bool submitPressed;

    private Vector2 navigationDirection = Vector2.zero;

    private bool escapePressed;


    private static InputManager instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("There are more InputManager in the scene.");
        }

        instance = this;
    }

    public static InputManager GetInstance()
    {
        return instance;
    }


    public void FlyMovement(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {
            moveDirection = ctx.ReadValue<Vector2>();
        }
        else if (ctx.canceled)
        {
            moveDirection = ctx.ReadValue<Vector2>();
        }
    }

    public void Radar(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {
            radarPressed = true;
        }
        else if (ctx.canceled)
        {
            radarPressed = false;
        }
    }

    public void Acceleration(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {
            accelerationChange = ctx.ReadValue<float>();
        }
        else if (ctx.canceled)
        {
            accelerationChange = ctx.ReadValue<float>();
        }
    }

    public void ShootPressed(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {
            shootPressed = true;
        }
        else if (ctx.canceled)
        {
            shootPressed = false;
        }
    }

    public void NavigationPressed(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {
            navigationDirection = ctx.ReadValue<Vector2>();
        }
        else if (ctx.canceled)
        {
            navigationDirection = ctx.ReadValue<Vector2>();
        }
    }


    public void SubmitPressed(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {
            submitPressed = true;
        }
        else if (ctx.canceled)
        {
            submitPressed = false;
        }
    }

    public void EscapePressed(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {
            escapePressed = true;
        }
        else if (ctx.canceled)
        {
            escapePressed = false;
        }
    }

    public Vector2 GetMouseDelta()
    {
        return moveDirection;
    }

    public float AccelarationChange()
    {
        return accelerationChange;
    }

    public bool IsRadarPressed()
    {
        bool result = radarPressed;
        radarPressed = false;
        return result;
    }

    public bool GetShootPressed()
    {
        bool result = shootPressed;
        shootPressed = false;
        return result;
    }

    public Vector2 GetNavigationPressed()
    {
        return navigationDirection;
    }

    public bool GetSubmitPressed()
    {
        bool result = submitPressed;
        submitPressed = false;
        return result;
    }

    public bool GetEscapePressed()
    {
        bool result = escapePressed;
        escapePressed = false;
        return result;
    }
}