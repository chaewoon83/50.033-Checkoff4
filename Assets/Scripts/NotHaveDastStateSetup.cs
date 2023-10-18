using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PluggableSM/Actions/NotHaveDastStateSetup")]
public class NotHaveDastStateSetup : Action
{
    public GameConstants Constants;
    override public void Act(StateController controller)
    {
        Material newMat = Resources.Load("BlueMad", typeof(Material)) as Material;
        controller.transform.GetComponentInChildren<SpriteRenderer>().material = newMat;    
    }

}
