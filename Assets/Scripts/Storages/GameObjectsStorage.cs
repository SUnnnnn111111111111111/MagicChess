using System.Collections.Generic;
using UnityEngine;

public class GameObjectsStorage : MonoBehaviour
{
    [field:SerializeField] public List<GameObject> GameObjects{ get; set; } 

    public void AddGameObjects(GameObject gameObject)
    {
        GameObjects.Add(gameObject);
    }
}
