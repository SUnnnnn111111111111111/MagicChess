using UltEvents;
using UnityEngine;

public abstract class GlobalValueStorage<T> : ScriptableObject
{
    [field:SerializeField] public T Value 
    { 
        get => _Value;
        set
        {
            if(object.Equals(_Value, value)) return;

            if(_Value != null && !_Value.Equals(null))
            {
                BeforeSet.Invoke(_Value);
            }

            _Value = value;

            if(_Value != null && !_Value.Equals(null))
            {
                AfterSet.Invoke(_Value);
            }
        }
    }

    [SerializeField] private T _Value;
    [SerializeField] private UltEvent<T> BeforeSet;
    [SerializeField] private UltEvent<T> AfterSet;
}