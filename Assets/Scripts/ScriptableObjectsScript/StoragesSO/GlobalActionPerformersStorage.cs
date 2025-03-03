using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


[CreateAssetMenu(fileName = "GlobalActionPerformersStorage", menuName = "GlobalValueStorage/GlobalActionPerformersStorage")]
public class GlobalActionPerformersStorage : GlobalValueStorage<List<ActionPerformer>>
{
    public void AddObject(ActionPerformer _object)
    {
        Value.Add(_object);
    }

    public ActionPerformer GetRandomObject() => Value[Random.Range(0, Value.Count)];

    public void RemoveObject(ActionPerformer _object)
    {
        Value.Remove(_object);
    }

    public bool IsNotNull => Value.Count != 0;
}
