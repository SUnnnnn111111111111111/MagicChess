using UnityEngine;

[CreateAssetMenu(fileName = "GlobalBoolStorage", menuName = "ScriptableObjects/GlobalBoolStorage", order = 1)]
public class GlobalBoolStorage : ScriptableObject
{
    [field:SerializeField] public bool Bool{ get; set; } 
}
