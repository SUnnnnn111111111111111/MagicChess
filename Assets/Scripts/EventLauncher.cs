using UnityEngine;
using UltEvents;

public class EventLauncher : MonoBehaviour
{
    [SerializeField] private UltEvent Event;

    public void LaunchEvent()
    {
        Event.Invoke();
    }
    public void LaunchEvent(float delay)
    {
        Invoke(nameof(LaunchEvent), delay);
    }
}
