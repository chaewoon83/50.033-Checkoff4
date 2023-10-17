using UnityEngine;

[CreateAssetMenu(menuName = "PluggableSM/Actions/MovetoIdleAction")]
public class MovetoIdleAction : Action
{
    public State MadIdleState;
    public BoolVariable IsMoving;
    public override void Act(StateController controller)
    {
        controller.TransitionToState(MadIdleState);
    }
}
