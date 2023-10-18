using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

[CreateAssetMenu(menuName = "PluggableSM/Actions/ClimbMoveSoundAction")]
public class ClimbMoveSoundAction : Action
{
    public AudioClip ClimbMoveSound;
    public float SoundDelayTime = 0.3f;
    private float CurSoundDelayTime;
    override public void Act(StateController controller)
    {
        if (CurSoundDelayTime > 0.0f)
        {
            CurSoundDelayTime -= Time.deltaTime;
        }
        else
        {
            controller.GetComponent<AudioSource>().PlayOneShot(ClimbMoveSound);
            CurSoundDelayTime = SoundDelayTime;
        }

    }


}
