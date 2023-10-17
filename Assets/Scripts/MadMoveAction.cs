using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PluggableSM/Actions/MadMoveAction")]
public class MadMoveAction : Action
{
    public FloatVariable HorMoveValue;
    public BoolVariable IsMoving;
    public BoolVariable faceRightState;
    public GameConstants Constants;
    override public void Act(StateController controller)
    {
        int faceRight = HorMoveValue.Value > 0 ? 1 : -1;

        MoveHorizontalCheck(faceRight, controller);
    }
    public void MoveHorizontalCheck(int value, StateController controller)
    { 
        FlipSprite(value, controller);
        MoveHorizontal(value, controller);
    }

    void MoveHorizontal(int value, StateController controller)
    {
        Rigidbody2D RigidBody = controller.GetComponent<Rigidbody2D>();
        Vector2 movement = new Vector2(value, 0);
        RigidBody.AddForce(movement * Constants.speed, ForceMode2D.Force);
        //Debug.Log("Speedddd");
        //Debug.Log("123123123");
        // check if it doesn't go beyond maxSpeed
        if (MathF.Abs(RigidBody.velocity.x) > Constants.maxSpeed)
        {
            RigidBody.velocity = new Vector2(Constants.maxSpeed * value, RigidBody.velocity.y);
        }

    }

    void FlipSprite(int value, StateController controller)
    {
        SpriteRenderer spriteRenderer = controller.GetComponentInChildren<SpriteRenderer>();
        if (value == -1)
        {
            faceRightState.Value = false;
            spriteRenderer.flipX = true;
        }

        else if (value == 1)
        {
            faceRightState.Value = true;
            spriteRenderer.flipX = false;
        }
    }
}
