using System.Collections.Generic;
using UnityEngine;

public class ObjectsStorage : MonoBehaviour
{
    [field:SerializeField] public List<ActionPerformer> Objects{ get; set; } 

    public void AddGameObjects(ActionPerformer _object)
    {
        Objects.Add(_object);
    }
}
