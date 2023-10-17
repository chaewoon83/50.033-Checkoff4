using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

[CreateAssetMenu(fileName = "FloatVariable", menuName = "ScriptableObjects/FloatVariable", order = 4)]
public class FloatVariable : Variable<float>
{

    public override void SetValue(float value)
    {
        _value = value;
    }

    // overload
    public void SetValue(FloatVariable value)
    {
        SetValue(value.Value);
    }



}