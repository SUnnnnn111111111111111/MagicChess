using UnityEngine;

[CreateAssetMenu(fileName = "GlobalBoolStorageSO", menuName = "GlobalStorageSO/GlobalBoolStorageSO")]
public class GlobalBoolStorageSO : ScriptableObject
{
    [field:SerializeField] public bool valueBool{ get; set; } 
}
