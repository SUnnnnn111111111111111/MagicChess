using UnityEngine;
using UltEvents;

public class EventLauncher<T> : EventLauncher
{
    [SerializeField] private UltEvent<T> Event;
    private T delayValue;

    public void Launch(T value)
    {
        Event.Invoke(value);
    }
    public void Launch(T value, float delay)
    {
        delayValue = value;
        Invoke(nameof(LaunchAfterDelay), delay);
    }

    private void LaunchAfterDelay()
    {
        Launch(delayValue);
    }
    
    public void LaunchIfTrue(bool boolValue, T value)
    {
        if (boolValue) Launch(value);
    }
    
    public void LaunchIfFalse(bool boolValue, T value)
    {
        if (!boolValue) Launch(value);
    }
    
    private void OnDisable()
    {
        CancelInvoke();
    }
}

public abstract class EventLauncher : MonoBehaviour
{
    
}