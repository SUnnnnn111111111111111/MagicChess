using UnityEngine;
using UltEvents;

public class TriggerHandler : MonoBehaviour
{
    [SerializeField] private UltEvent<Collider> OnEnter;

    public void OnTriggerEnter(Collider other)
    {
        OnEnter.Invoke(other);
    }
}
