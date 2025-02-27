using UnityEngine;

[CreateAssetMenu(fileName = "GlobalBoolStorageSO", menuName = "GlobalStorageSO/GlobalBoolStorageSO")]
public class GlobalBoolStorage : ScriptableObject
{
    [field:SerializeField] public bool Bool{ get; set; } 
}
