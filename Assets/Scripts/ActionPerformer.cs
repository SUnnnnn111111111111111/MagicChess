using UnityEngine;
using UltEvents;
using System.Collections.Generic;
using System;
using System.Linq;


public class ActionPerformer : MonoBehaviour
{
    private Dictionary<ActionSO, EventLauncher> actionPerformers;

    void Awake()
    {
        actionPerformers = GetComponentsInChildren<ActionTarget>().ToDictionary(actionTarget => actionTarget.actionSO,
            actionTarget => actionTarget.gameObject.GetComponent<EventLauncher>());
    }

    public static void PerformAction(ActionPerformer aP, ActionSO aSO, int v)
    {       
        aP.PerformAction(aSO, v);
    }
    
    public static void PerformAction(ActionPerformer aP, ActionSO aSO, float v)
    {       
        aP.PerformAction(aSO, v);
    }
    
    public static void PerformAction(ActionPerformer aP, ActionSO aSO)
    {       
        aP.PerformAction(aSO, new @void());
    }
    public void PerformAction<T>(ActionSO actionSO, T value)
    {
        (actionPerformers[actionSO] as EventLauncher<T>).LaunchEvent(value);
    }
}
