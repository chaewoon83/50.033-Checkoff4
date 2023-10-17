using UnityEngine;

[CreateAssetMenu(menuName = "PluggableSM/Actions/IdletoJumpAction")]
public class IdletoJumpAction : Action
{
    public State MadJumpState;
    public BoolVariable OnGround;
    public override void Act(StateController controller)
    {
        OnGround.SetValue(false);
        controller.TransitionToState(MadJumpState);
    }
}
