using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectMadelineClimbing : MonoBehaviour
{
    public BoolVariable IsLeftClimbe;
    public BoolVariable IsRightClimbe;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.gameObject.CompareTag("LeftClimbCollider") == true)
        {
            Debug.Log("OnLeftClimb");
            IsLeftClimbe.SetValue(true);
        }
        if (collision.transform.gameObject.CompareTag("RightClimbCollider") == true)
        {
            Debug.Log("OnRightClimb");
            IsRightClimbe.SetValue(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.transform.gameObject.CompareTag("LeftClimbCollider") == true)
        {
            Debug.Log("LeaveLeftClimb");
            IsLeftClimbe.SetValue(false);
        }
        if (collision.transform.gameObject.CompareTag("RightClimbCollider") == true)
        {
            Debug.Log("LeaveRightClimb");
            IsRightClimbe.SetValue(false);
        }
    }
}
