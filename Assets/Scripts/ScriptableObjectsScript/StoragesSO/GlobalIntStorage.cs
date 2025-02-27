using UnityEngine;

[CreateAssetMenu(fileName = "GlobalIntStorageSO", menuName = "GlobalStorageSO/GlobalIntStorageSO")]
public class GlobalIntStorage : ScriptableObject
{
    [field:SerializeField] public int Int{ get; set; } 
}
