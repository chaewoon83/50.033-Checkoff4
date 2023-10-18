using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


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

public class DashStateController : StateController
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

    public void DashableState()
    {
        this.currentState.DoEventTriggeredActions(this, ActionType.NoDash);
    }
    public void NotDashableState()
    {
        this.currentState.DoEventTriggeredActions(this, ActionType.Dash);
    }
}