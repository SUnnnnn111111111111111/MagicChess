using UnityEngine;
using UltEvents;
using UnityEngine.Assertions.Must;
using System.Collections.Generic;
using System.Linq;
using System;


public class ActionPerformer : MonoBehaviour
{
    private Dictionary<string ,EventLauncher> actionPerformers;

    void Awake()
    {
        actionPerformers = GetComponentsInChildren<EventLauncher>().ToDictionary(performer => performer.name);
    }

    public void Perform(string actionName)
    {       
        actionPerformers[actionName].LaunchEvent();
    }
}
