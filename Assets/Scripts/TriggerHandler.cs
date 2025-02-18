using UnityEngine;
using UltEvents;

public class TriggerHandler : MonoBehaviour
{
    [SerializeField] private UltEvent<GameObject> OnEnter;

    public void OnTriggerEnter(Collider other)
    {
        OnEnter.Invoke(other.gameObject);
    }
}
