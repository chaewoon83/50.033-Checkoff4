using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PluggableSM/Actions/NotHaveDashBasicAction ")]
public class NotHaveDashBasicAction : Action
{
    public BoolVariable OnGround;
    public BoolVariable IsDash;
    public State HaveDashState;
    override public void Act(StateController controller)
    {
        if(OnGround.Value == true && IsDash.Value == false)
        {
            controller.TransitionToState(HaveDashState);
        }
    }

}
