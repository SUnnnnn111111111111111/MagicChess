using UnityEngine;

[CreateAssetMenu(fileName = "GlobalGameObjectStorage", menuName = "ScriptableObjects/GlobalGameObjectStorage", order = 1)]
public class GlobalGameObjectStorage : ScriptableObject
{
    [field:SerializeField] public GameObject GameObject{ get; set; } 
}
