using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PluggableSM/Actions/MaterialChange")]
public class HaveDastStateSetup : Action
{
    public Material newMat;
    public GameConstants Constants;
    override public void Act(StateController controller)
    {
        controller.transform.GetComponentInChildren<SpriteRenderer>().material = newMat;    
    }

}
