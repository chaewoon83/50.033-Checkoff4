using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PluggableSM/Actions/DashBasicAction")]
public class DashBasicAction : Action
{
    public FloatVariable HorDashValue;
    public FloatVariable VerDashValue;
    public BoolVariable faceRightState;
    public GameConstants Constants;
    override public void Act(StateController controller)
    {
        int faceRight = HorDashValue.Value > 0 ? 1 : -1;
        Dash(controller);
    }
    void Dash(StateController controller)
    {
        Rigidbody2D RigidBody = controller.GetComponent<Rigidbody2D>();
        Vector2 movement = new Vector2(HorDashValue.Value, VerDashValue.Value);
        RigidBody.AddForce(movement * Constants.DashSpeed, ForceMode2D.Force);
        //Debug.Log("Speedddd");
        //Debug.Log("123123123");
        // check if it doesn't go beyond maxSpeed
        if (MathF.Abs(RigidBody.velocity.magnitude) > Constants.DashMaxSpeed)
        {
            RigidBody.velocity = RigidBody.velocity.normalized * Constants.DashMaxSpeed;
        }

    }
}
