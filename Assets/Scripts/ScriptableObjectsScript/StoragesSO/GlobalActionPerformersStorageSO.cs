using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


[CreateAssetMenu(fileName = "GlobalActionPerformersStorageSO", menuName = "GlobalStorageSO/GlobalActionPerformersStorageSO")]
public class GlobalActionPerformersStorageSO : ScriptableObject
{
    [field:SerializeField] public List<ActionPerformer> Objects{ get; set; } 

    public void AddObject(ActionPerformer _object)
    {
        Objects.Add(_object);
    }

    public ActionPerformer GetRandomObject() => Objects[Random.Range(0, Objects.Count)];

    public void RemoveObject(ActionPerformer _object)
    {
        Objects.Remove(_object);
    }

    public bool IsNotNull => Objects.Count != 0;
}
