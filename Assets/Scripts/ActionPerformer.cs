using UnityEngine;
using UltEvents;
using System.Collections.Generic;
using System.Linq;
using ScriptableObjectsScript;
using UnityEngine.Assertions;
using Object = UnityEngine.Object;


public class ActionPerformer : MonoBehaviour
{
    private Dictionary<ActionSO, EventLauncher> actionPerformers;

    void Awake()
    {
        actionPerformers = GetComponentsInChildren<ActionTarget>().ToDictionary(actionTarget => actionTarget.actionSO,
            actionTarget => actionTarget.gameObject.GetComponent<EventLauncher>());
    }
    public static void PerformAction(ActionPerformer aP, ActionActionPerformerSO aSO, ActionPerformer v)
    {       
        aP.PerformAction(aSO, v);
    }
    
    public static void PerformAction(ActionPerformer aP, ActionIntSO aSO, int v)
    {       
        aP.PerformAction(aSO, v);
    }
    
    public static void PerformAction(ActionPerformer aP, ActionFloatSO aSO, float v)
    {       
        aP.PerformAction(aSO, v);
    }
    
    public static void PerformAction(ActionPerformer aP, ActionBoolSO aSO, bool v)
    {       
        aP.PerformAction(aSO, v);
    }
    
    public static void PerformAction(ActionPerformer aP, ActionMaterialSO aSO, Material v)
    {       
        aP.PerformAction(aSO, v);
    }
    
    public static void PerformAction(ActionPerformer aP, ActionVoidSO aSO)
    {       
        aP.PerformAction(aSO, new @void());
    }
    
    public static void PerformAction(ActionPerformer aP, ActionObjectSO aSO, Object v)
    {
        aP.PerformAction(aSO, v);
    }
    
    public void PerformAction<T>(ActionSO actionSO, T value)
    {
        EventLauncher<T> eventLauncherWithT = actionPerformers[actionSO] as EventLauncher<T>;
        Assert.IsNotNull(eventLauncherWithT, "The Action type does not match the EventLauncher type");
        eventLauncherWithT.LaunchEvent(value);
    }
}
