using UnityEngine;

[CreateAssetMenu(menuName = "PluggableSM/Actions/toClimbIdleAction")]
public class toClimbIdleAction : Action
{
    public State MadClimbIdleState;
    public override void Act(StateController controller)
    {
        controller.TransitionToState(MadClimbIdleState);
    }
}
