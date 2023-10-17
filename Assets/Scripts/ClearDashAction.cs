using UnityEngine;

[CreateAssetMenu(menuName = "PluggableSM/Actions/ClearDashAction")]
public class ClearDashAction : Action
{
    public override void Act(StateController controller)
    {
        MadelineStateController m = (MadelineStateController)controller;
        m.currentDashState = DashState.Default;
    }
}