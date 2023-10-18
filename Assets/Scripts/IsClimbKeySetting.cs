using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PluggableSM/Actions/IsClimbKeySetting")]
public class IsClimbKeySetting : Action
{
    public BoolVariable IsClimbKeyOn;
    override public void Act(StateController controller)
    {
        IsClimbKeyOn.SetValue(false);
    }

}
