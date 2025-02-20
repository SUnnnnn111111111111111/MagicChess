using UnityEngine;
using UltEvents;

public class BoolStorage : ValueStorage<bool>
{
    public bool EqualityOfBoolToValue(bool _bool)
    {
        return value == _bool;
    }
}