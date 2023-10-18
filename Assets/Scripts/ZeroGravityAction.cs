using UnityEngine;

[CreateAssetMenu(menuName = "PluggableSM/Actions/ZeroGravityAction")]
public class ZeroGravityAction : Action
{
    public override void Act(StateController controller)
    {
        Rigidbody2D Rigidbody = controller.GetComponentInChildren<Rigidbody2D>();
        if (Rigidbody != null)
        {
            Rigidbody.gravityScale = 0.0f; 
            //Rigidbody.Sleep();
        }

    }
}
