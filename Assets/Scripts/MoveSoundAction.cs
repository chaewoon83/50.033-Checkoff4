using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

[CreateAssetMenu(menuName = "PluggableSM/Actions/MoveSoundAction")]
public class MoveSoundAction : Action
{
    public AudioClip WalkSound;
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
            controller.GetComponent<AudioSource>().PlayOneShot(WalkSound);
            CurSoundDelayTime = SoundDelayTime;
        }

    }


}
