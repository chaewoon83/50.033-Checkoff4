using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class ActionManager : MonoBehaviour
{
    public UnityEvent jump;
    public UnityEvent Dash;
    public UnityEvent moveCheck;
    public UnityEvent StopCheck;
    public UnityEvent ClimbCheck;
    public UnityEvent ClimbMoveCheck;
    public UnityEvent ClimbMoveEnd;
    public UnityEvent ClimbEnd;

    public FloatVariable HorMoveValue;
    public FloatVariable VerMoveValue;
    public BoolVariable IsMoving;
    public BoolVariable IsClimbKeyOn;
    public BoolVariable IsLeftClimb;
    public BoolVariable IsRightClimb;
    // called twice, when pressed and unpressed
    public void OnJumpAction(InputAction.CallbackContext context)
    {
        if (context.started)
            Debug.Log("Jump was started");
        else if (context.performed)
        {
            jump.Invoke();
            Debug.Log("Jump was performed");
        }
        else if (context.canceled)
            Debug.Log("Jump was cancelled");

    }

    // called twice, when pressed and unpressed
    public void OnMoveAction(InputAction.CallbackContext context)
    {
        // Debug.Log("OnMoveAction callback invoked");
        if (context.started)
        {
            Debug.Log("move started");
            HorMoveValue.SetValue(context.ReadValue<float>());
            IsMoving.SetValue(true);
            moveCheck.Invoke();
        }
        if (context.canceled)
        {
            Debug.Log("move stopped");
            HorMoveValue.SetValue(0);
            StopCheck.Invoke();
            IsMoving.SetValue(false);
            Debug.Log(IsMoving.Value);
        }

    }
    public void OnDashAction(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            Dash.Invoke();
            Debug.Log("dash started");
        }
        else if (context.performed)
        {

            Debug.Log("dash performed");
        }
        else if (context.canceled)
            Debug.Log("dash cancelled");
    }

    public void OnClimbAction(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            IsClimbKeyOn.SetValue(true);
        }

        else if (context.performed)
        {
            IsClimbKeyOn.SetValue(true);


            Debug.Log("climb performed");
        }
        else if (context.canceled)
        {
            IsClimbKeyOn.SetValue(false);
            ClimbEnd.Invoke();
            Debug.Log("climb cancelled");
        }

    }

    public void OnClimbMoveAction(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            Debug.Log("climb move started");
        }

        else if (context.performed)
        {
            VerMoveValue.SetValue(context.ReadValue<float>());
            if (IsLeftClimb.Value == true || IsRightClimb.Value == true)
            {
                ClimbMoveCheck.Invoke();
            }
            Debug.Log("climb move performed");
        }
        else if (context.canceled)
        {
            VerMoveValue.SetValue(0);
            ClimbMoveEnd.Invoke();
            Debug.Log("climb move cancelled");
        }
    }
}
