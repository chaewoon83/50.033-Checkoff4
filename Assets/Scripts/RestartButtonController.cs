using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RestartButtonController : MonoBehaviour
{
    public UnityEvent gameRestart;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CallGameRestart()
    {
        gameRestart.Invoke();
    }
}
