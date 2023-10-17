using UnityEngine;

[CreateAssetMenu(menuName = "PluggableSM/Actions/IdletoMoveAction")]
public class IdletoMoveAction : Action
{
    public State MadMoveState;
    public override void Act(StateController controller)
    {
        controller.TransitionToState(MadMoveState);
    }
}
