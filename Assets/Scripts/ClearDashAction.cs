using UnityEngine;

[CreateAssetMenu(menuName = "PluggableSM/Actions/ClearDashAction")]
public class ClearDashAction : Action
{
    public override void Act(StateController controller)
    {
        DashStateController m = (DashStateController)controller;
        m.currentDashState = DashState.Default;
    }
}