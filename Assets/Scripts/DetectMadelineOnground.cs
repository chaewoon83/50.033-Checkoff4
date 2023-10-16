using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectMadelineOnground : MonoBehaviour
{
    PlayerMovement Movement;
    // Start is called before the first frame update
    void Start()
    {
        Movement = transform.parent.GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.gameObject.layer == 6)
        {
            Debug.Log("OnGround");
            Movement.OnGroundState = true;
        }
    }
}
