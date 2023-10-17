using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializeVariables : MonoBehaviour
{
    // Start is called before the first frame update

    public BoolVariable FaceRight;
    public BoolVariable IsClimbKeyOn;
    public BoolVariable IsLeftClimb;
    public BoolVariable IsRightClimb;
    public BoolVariable IsOnDash;
    public BoolVariable IsOnGround;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Awake()
    {
        FaceRight.SetValue(true);
        IsClimbKeyOn.SetValue(false);
        IsLeftClimb.SetValue(false);
        IsRightClimb.SetValue(false);
        IsOnDash.SetValue(false);
        IsOnGround.SetValue(false);
    }
}
