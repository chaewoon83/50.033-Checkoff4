using UnityEngine;

[CreateAssetMenu(menuName = "PluggableSM/Actions/DashStateExit")]
public class DashStateExit : Action
{
	public BoolVariable IsDash;
	public override void Act(StateController controller)
	{
		IsDash.SetValue(false);
    }
}