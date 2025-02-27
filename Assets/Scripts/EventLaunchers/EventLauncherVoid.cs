using System;
using UnityEngine;
using UltEvents;

public class EventLauncherVoid : EventLauncher<@void>
{
    public void Launch()
    {
        LaunchEvent(new @void());
    }

    public void Launch(float delay)
    {
        LaunchEvent(new @void(), delay);
    }
}

public struct @void
{
}
