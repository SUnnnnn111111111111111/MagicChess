using UltEvents;
using UnityEngine;
using UnityEngine.Serialization;


[CreateAssetMenu(fileName = "GlobalIntStorage", menuName = "GlobalValueStorage/GlobalIntStorage")]
public class GlobalIntStorage : GlobalValueStorage<int>
{
    public void Change(int difference)
    {
        Value += difference;
    }
    
    public bool EqualityOfNumberToValue(int difference)
    {
        return Value == difference;
    }
}
