using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ActionPerformersStorage : MonoBehaviour
{
    [field:SerializeField] public List<ActionPerformer> Objects{ get; set; } 

    public void AddGameObjects(ActionPerformer _object)
    {
        Objects.Add(_object);
    }

    public ActionPerformer GetRandomObject() => Objects[Random.Range(0, Objects.Count)];
}
