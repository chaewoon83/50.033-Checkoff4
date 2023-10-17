using UnityEngine;

[CreateAssetMenu(menuName = "PluggableSM/Actions/IdleBasicAction")]
public class IdleBasicAction : Action
{
    public BoolVariable IsMoving;
    public State MoveState;
    public override void Act(StateController controller)
    {
        Rigidbody2D Rigidbody = controller.GetComponentInChildren<Rigidbody2D>();
        if (Rigidbody != null)
        {
            Rigidbody.velocity = Vector2.up * Rigidbody.velocity.y;
        }

    }
}
