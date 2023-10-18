using UnityEngine;

[CreateAssetMenu(menuName = "PluggableSM/Actions/CheckClimbStartAction")]
public class CheckClimbStartAction : Action
{
    public BoolVariable IsRightClimb;
    public BoolVariable IsLeftClimb;
    public BoolVariable IsClimbKeyOn;
    public State ClimbIdle;
    public override void Act(StateController controller)
    {
        if((IsRightClimb.Value == true || IsLeftClimb.Value == true) && IsClimbKeyOn.Value == true)
        {
            controller.TransitionToState(ClimbIdle);
        }
    }
}
