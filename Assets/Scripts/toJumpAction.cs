using UnityEngine;

[CreateAssetMenu(menuName = "PluggableSM/Actions/toJumpAction")]
public class toJumpAction : Action
{
    public State MadJumpState;
    public BoolVariable OnGround;
    public override void Act(StateController controller)
    {
        controller.TransitionToState(MadJumpState);
    }
}
