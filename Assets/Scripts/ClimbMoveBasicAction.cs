using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PluggableSM/Actions/ClimbMoveBasicAction")]
public class ClimbMoveBasicAction : Action
{
    public FloatVariable VerMoveValue;
    public GameConstants Constants;
    override public void Act(StateController controller)
    {
        MoveVertical(VerMoveValue.Value, controller);
    }

    void MoveVertical(float value, StateController controller)
    {
        Rigidbody2D RigidBody = controller.GetComponent<Rigidbody2D>();
        Vector2 movement = new Vector2(0, value);
        RigidBody.AddForce(movement * Constants.ClimbSpeed, ForceMode2D.Force);
        //Debug.Log("Speedddd");
        //Debug.Log("123123123");
        // check if it doesn't go beyond maxSpeed
        if (RigidBody.velocity.y > Constants.ClimbMaxSpeed)
        {
            RigidBody.velocity = Constants.ClimbMaxSpeed * Vector2.up;
        }

        if (RigidBody.velocity.y < -1 * Constants.ClimbMaxSpeed)
        {
            RigidBody.velocity = Constants.ClimbMaxSpeed * Vector2.down;
        }

    }
}
