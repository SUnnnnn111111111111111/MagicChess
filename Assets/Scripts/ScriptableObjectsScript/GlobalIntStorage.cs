using UnityEngine;

[CreateAssetMenu(fileName = "GlobalIntStorage", menuName = "ScriptableObjects/GlobalIntStorage", order = 1)]
public class GlobalIntStorage : ScriptableObject
{
    [field:SerializeField] public int Int{ get; set; } 
}
