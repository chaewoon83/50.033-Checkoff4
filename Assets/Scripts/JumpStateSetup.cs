using UnityEngine;

[CreateAssetMenu(menuName = "PluggableSM/Actions/JumpStateSetup")]
public class JumpStateSetup : Action
{
    public GameConstants GameConstant;
    public override void Act(StateController controller)
    {
        Rigidbody2D Rigidbody = controller.GetComponentInChildren<Rigidbody2D>();
        if (Rigidbody != null)
        {
            Rigidbody.AddForce(GameConstant.upSpeed * Vector2.up, ForceMode2D.Impulse);
        }
    }
}
