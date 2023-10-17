using System;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(menuName = "PluggableSM/Actions/JumpBasicAction")]
public class JumpBasicAction : Action
{
    public BoolVariable OnGround;
    public State IdleState;
    public State MoveState;

    //For Movement
    public FloatVariable HorMoveValue;
    public BoolVariable IsMoving;
    public BoolVariable faceRightState;
    public GameConstants Constants;
    public override void Act(StateController controller)
    {
        if(OnGround.Value == true)
        {
            if (IsMoving.Value == true)
            {
                controller.TransitionToState(MoveState);
            }
            else
            {
                controller.TransitionToState(IdleState);
            }
        }

        if(IsMoving.Value == true)
        {
            int faceRight = HorMoveValue.Value > 0 ? 1 : -1;
            MoveHorizontalCheck(faceRight, controller);
        }

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
        RigidBody.AddForce(movement * Constants.jumpHorSpeed, ForceMode2D.Force);
        Debug.Log("Speedddd");
        Debug.Log("123123123");
        // check if it doesn't go beyond maxSpeed
        if (RigidBody.velocity.x > Constants.maxSpeed)
        {
            RigidBody.velocity = new Vector2(Constants.maxSpeed, RigidBody.velocity.y);
        }

        if (RigidBody.velocity.x  < -1 * Constants.maxSpeed)
        {
            RigidBody.velocity = new Vector2(-1 * Constants.maxSpeed, RigidBody.velocity.y);
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
