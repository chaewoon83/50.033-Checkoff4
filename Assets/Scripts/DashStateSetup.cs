using UnityEngine;

[CreateAssetMenu(menuName = "PluggableSM/Actions/DashStateSetup")]
public class DashStateSetup : Action
{
	public BoolVariable IsDash;
	public FloatVariable InputVerValue;
	public FloatVariable InputHorValue;
	public FloatVariable DashVerValue;
	public FloatVariable DashHorValue;
    public AudioClip DashSound;

    public override void Act(StateController controller)
	{
        DashVerValue.SetValue(InputVerValue.Value);
        DashHorValue.SetValue(InputHorValue.Value);
        IsDash.SetValue(true);
		controller.GetComponent<Rigidbody2D>().Sleep();
        controller.GetComponent<AudioSource>().PlayOneShot(DashSound);
    }
}