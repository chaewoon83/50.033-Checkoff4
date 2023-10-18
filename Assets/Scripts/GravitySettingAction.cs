using UnityEngine;

[CreateAssetMenu(menuName = "PluggableSM/Actions/GravitySettingAction")]
public class GravitySettingAction : Action
{
    public GameConstants Constant;
    public BoolVariable IsClimbKeyOn;
    public override void Act(StateController controller)
    {
        Rigidbody2D Rigidbody = controller.GetComponentInChildren<Rigidbody2D>();
        if (Rigidbody != null)
        {
            IsClimbKeyOn.SetValue(false);
            Rigidbody.gravityScale = Constant.Gravity;
            //Rigidbody.Sleep();
        }

    }
}
