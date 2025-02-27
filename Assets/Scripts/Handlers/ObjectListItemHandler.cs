using System.Collections.Generic;
using UltEvents;
using UnityEngine;

public class ObjectListItemHandler : MonoBehaviour
{
    [SerializeField] private UltEvent<ActionPerformer> OnHadle;

    public void HandleTheList(List<ActionPerformer> _objectList)
    {
        foreach(ActionPerformer _object in _objectList)
        {
            OnHadle.Invoke(_object);
        }
    }
}
