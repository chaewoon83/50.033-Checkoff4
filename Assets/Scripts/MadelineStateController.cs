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

public enum DashState
{
    Default = -1,
    DashOnce = 0,
    DashTwice = 1,

}

/// <summary>
/// TODO Reset Variables
/// </summary>
/// 

public class MadelineStateController : StateController
{
    public MadelineState shouldBeNextState = MadelineState.Default;
    public DashState currentDashState = DashState.Default;


    public override void Start()
    {
        base.Start();
        GameRestart(); // clear powerup in the beginning, go to start state
    }

    // this should be added to the GameRestart EventListener as callback
    public void GameRestart()
    {
        // clear powerup
        currentDashState = DashState.Default;
        // set the start state
        TransitionToState(startState);
    }

    public void SetDash(DashState i)
    {
        currentDashState = i;
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

    public void Climb()
    {
        this.currentState.DoEventTriggeredActions(this, ActionType.Climb);
    }

}