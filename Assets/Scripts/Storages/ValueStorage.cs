using UnityEngine;
using UltEvents;

public class ValueStorage<T> : MonoBehaviour
{
    [field:SerializeField] public T value 
    { 
        get => _value;
        set
        {
            // Debug.Log($"BeforeSet1. В хранилище находится {name} , старое значение :{_value}", gameObject);
            if(object.Equals(_value, value)) return;

            if(_value != null && !_value.Equals(null))
            {
                // Debug.Log($"BeforeSet1. В хранилище находится {name} , старое значение :{_value}", gameObject);
                BeforeSet.Invoke(_value);
                // Debug.Log($"BeforeSet1. В хранилище находится {name} , старое значение :{_value}", gameObject);
            }

            _value = value;

            if(_value != null && !_value.Equals(null))
            {
                // Debug.Log($"AfterSet1. В хранилище находится {name} , старое значение :{_value}", gameObject);
                AfterSet.Invoke(_value);
                // Debug.Log($"AfterSet2. В хранилище находится {name} , старое значение :{_value}", gameObject);
            }
        }
    }

    [SerializeField] private T _value;
    [SerializeField] private UltEvent<T> BeforeSet;
    [SerializeField] private UltEvent<T> AfterSet;
}