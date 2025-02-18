using System.Collections.Generic;
using UltEvents;
using UnityEngine;

public class GameObjectListItemHandler : MonoBehaviour
{
    [SerializeField] private UltEvent<GameObject> OnHadle;

    public void HandleTheList(List<GameObject> gameObjectlist)
    {
        foreach(GameObject gameObject in gameObjectlist)
        {
            OnHadle.Invoke(gameObject);
        }
    }
}
