using UnityEngine;

[CreateAssetMenu(menuName = "PluggableSM/Actions/GravitySettingAction")]
public class GravitySettingAction : Action
{
    public GameConstants Constant;
    public override void Act(StateController controller)
    {
        Rigidbody2D Rigidbody = controller.GetComponentInChildren<Rigidbody2D>();
        if (Rigidbody != null)
        {
            Rigidbody.gravityScale = Constant.Gravity;
            //Rigidbody.Sleep();
        }

    }
}
