using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public static class ActionPerformerColliders
{
    static Dictionary<Collider, ActionPerformer> actionPerformerColliders = new();

    public static void Add(Collider collider, ActionPerformer actionPerformer)
    {
        actionPerformerColliders[collider] = actionPerformer;
    }

    public static ActionPerformer GetActionPerformer(Collider collider) => actionPerformerColliders[collider];
}
