using UnityEngine;
using UltEvents;

public class IntStorage : ValueStorage<int>
{

    [SerializeField] private UltEvent OnChangeTheInt;


    public void Change(int difference)
    {
        value += difference;
        OnChangeTheInt.Invoke();
    }

    public bool EqualityOfNumberToValue(int number)
    {
        return value == number;
    }
    
}
