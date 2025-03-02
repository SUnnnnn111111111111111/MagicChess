using System;
using UnityEngine;
using UltEvents;

public class EventLauncherVoid : EventLauncher<@void>
{
    public void Launch()
    {
        Launch(new @void());
    }

    public void Launch(float delay)
    {
        Launch(new @void(), delay);
    }
    
    public void LaunchIfTrue(bool boolValue)
    {
        if (boolValue) Launch();
    }
    
    public void LaunchIfFalse(bool boolValue)
    {
        if (!boolValue) Launch();
    }
}

public struct @void
{
}
