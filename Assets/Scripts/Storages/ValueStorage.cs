using UnityEngine;

public class ValueStorage<Tipe> : MonoBehaviour
{
    [field:SerializeField] public Tipe value { get; set; } 
}