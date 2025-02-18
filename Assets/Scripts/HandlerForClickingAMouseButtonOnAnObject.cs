using UnityEngine;
using UltEvents;

public class HandlerForClickingAMouseButtonOnAnObject : MonoBehaviour
{
    [SerializeField] private UltEvent  WhenClickOnAnObject;

    void OnMouseDown()
    {
        WhenClickOnAnObject.Invoke();
    }
}
