using UnityEngine;
using UltEvents;

public class EventLauncher<T> : EventLauncher
{
    [SerializeField] private UltEvent<T> Event;
    private T delayValue;

    public void LaunchEvent(T value)
    {
        Event.Invoke(value);
    }
    public void LaunchEvent(T value, float delay)
    {
        delayValue = value;
        Invoke(nameof(LaunchAfterDelay), delay);
    }

    private void LaunchAfterDelay()
    {
        LaunchEvent(delayValue);
    }
    private void OnDisable()
    {
        CancelInvoke();
    }
}

public abstract class EventLauncher : MonoBehaviour
{
    
}