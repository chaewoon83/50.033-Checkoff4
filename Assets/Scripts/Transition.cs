using UnityEngine;

[System.Serializable]

[CreateAssetMenu(menuName = "PluggableSM/Transition")]

public class Transition
{
    public Decision decision;
    public State trueState;
    public State falseState;

}