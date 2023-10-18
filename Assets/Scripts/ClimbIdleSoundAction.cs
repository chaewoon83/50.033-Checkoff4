using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

[CreateAssetMenu(menuName = "PluggableSM/Actions/ClimbIdleSoundAction")]
public class ClimbIdleSoundAction : Action
{
    public AudioClip ClimbStartSound;
    override public void Act(StateController controller)
    {
        if (controller.previousState.name != "MadClimbMoveState")
        {
            controller.GetComponent<AudioSource>().PlayOneShot(ClimbStartSound);
        }

    }


}
