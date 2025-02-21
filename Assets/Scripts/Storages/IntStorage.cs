using UnityEngine;
using UltEvents;

public class IntStorage : ValueStorage<int>
{
    public void Change(int difference)
    {
        value += difference;
    }

    public bool EqualityOfNumberToValue(int number)
    {
        return value == number;
    }
}
