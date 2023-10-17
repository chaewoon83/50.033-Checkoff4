using UnityEngine;

[CreateAssetMenu(menuName = "PluggableSM/Actions/IdleStateSetup")]
public class IdleStateSetup : Action
{
    public BoolVariable IsMoving;
    public override void Act(StateController controller)
    {
        Rigidbody2D Rigidbody = controller.GetComponentInChildren<Rigidbody2D>();
        if (Rigidbody != null)
        {
            Debug.Log("STOPPPPED");
            Rigidbody.velocity = new Vector2(0.0f, Rigidbody.velocity.y);
            //Rigidbody.Sleep();
        }

    }
}
