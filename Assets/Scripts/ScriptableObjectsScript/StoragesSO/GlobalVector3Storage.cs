using UnityEngine;

[CreateAssetMenu(fileName = "GlobalVector3StorageSO", menuName = "GlobalStorageSO/GlobalVector3StorageSO")]
public class GlobalVector3Storage : ScriptableObject
{
    [field:SerializeField] public Vector3 Vector3{ get; set; } 
}
