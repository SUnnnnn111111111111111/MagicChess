using UnityEngine;

[CreateAssetMenu(fileName = "GlobalVector3Storage", menuName = "ScriptableObjects/GlobalVector3Storage", order = 1)]
public class GlobalVector3Storage : ScriptableObject
{
    [field:SerializeField] public Vector3 Vector3{ get; set; } 
}
