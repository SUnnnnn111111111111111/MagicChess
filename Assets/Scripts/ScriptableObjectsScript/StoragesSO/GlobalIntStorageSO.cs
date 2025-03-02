using UltEvents;
using UnityEngine;
using UnityEngine.Serialization;


[CreateAssetMenu(fileName = "GlobalIntStorageSO", menuName = "GlobalStorageSO/GlobalIntStorageSO")]
public class GlobalIntStorageSO : ScriptableObject
{
    [SerializeField] private int valueInt;
    [SerializeField] private UltEvent<int> BeforeSet;
    [SerializeField] private UltEvent<int> AfterSet;

    public int Value
    {
        get => valueInt;

        set 
        {
            if(valueInt == value) return;
            BeforeSet.Invoke(value);
            valueInt = value;
            AfterSet.Invoke(value);
        }
    }
    
    public void Change(int difference)
    {
        Value += difference;
    }
    
    public bool EqualityOfNumberToValue(int difference)
    {
        return valueInt == difference;
    }
}
