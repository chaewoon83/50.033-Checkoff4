using UnityEngine;

[CreateAssetMenu(menuName = "PluggableSM/Actions/ClimbIdleBasicAction")]
public class ClimbIdleBasicAction : Action
{
    public override void Act(StateController controller)
    {
        Rigidbody2D Rigidbody = controller.GetComponentInChildren<Rigidbody2D>();
        if (Rigidbody != null)
        {
            Rigidbody.velocity = Vector2.zero;
        }

    }
}
