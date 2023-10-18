using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class MadelineDeadRestart : MonoBehaviour
{
    public UnityEvent gameRestart;
    public AudioClip DeadSound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.position.y < -2.356f)
        {
            CallGameRestart();
        }
    }

    public void CallGameRestart()
    {
        gameRestart.Invoke();
        this.GetComponent<AudioSource>().PlayOneShot(DeadSound);
    }
}
