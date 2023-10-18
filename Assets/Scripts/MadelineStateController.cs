using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum MadelineState
{
    Default = -1,
    Run = 1,
    Jump = 2,
    Dash = 3,

}


public class MadelineStateController : StateController
{
    public MadelineState shouldBeNextState = MadelineState.Default;
    public BoolVariable IsClimbKeyOn;
    public BoolVariable IsLeftClimbOn;
    public BoolVariable IsRightClimbOn;
    public StateController HaveDash;

    public override void Start()
    {
        base.Start();
        GameRestart(); // clear powerup in the beginning, go to start state
    }

    // this should be added to the GameRestart EventListener as callback
    public void GameRestart()
    {
        // set the start state
        TransitionToState(startState);
        transform.position = Vector3.zero;
    }
    public void Move()
    {
        this.currentState.DoEventTriggeredActions(this, ActionType.Move);
    }
    public void Jump()
    {
        this.currentState.DoEventTriggeredActions(this, ActionType.Jump);
    }
    public void Stop()
    {
        this.currentState.DoEventTriggeredActions(this, ActionType.Stop);
    }

    public void Dash()
    {
        if (HaveDash.currentState.name == "HaveDashState") 
        {
            this.currentState.DoEventTriggeredActions(this, ActionType.Dash);
        }
    }
    public void ClimbStart()
    {
        this.currentState.DoEventTriggeredActions(this, ActionType.Climb);
    }
    public void ClimbMove()
    {
        this.currentState.DoEventTriggeredActions(this, ActionType.ClimbMove);
    }
    public void ClimbEnd()
    {
        this.currentState.DoEventTriggeredActions(this, ActionType.ClimbEnd);
    }

}