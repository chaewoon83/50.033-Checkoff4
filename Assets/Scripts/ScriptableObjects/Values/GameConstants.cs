using UnityEngine;

[CreateAssetMenu(fileName = "GameConstants", menuName = "ScriptableObjects/GameConstants", order = 1)]
public class GameConstants : ScriptableObject
{
    // Mario's movement
    public int speed;
    public int maxSpeed;
    public int upSpeed;
    public int jumpHorSpeed;
    public int ClimbSpeed;
    public int ClimbMaxSpeed;
    public Vector3 madelineStartingPosition;
}
