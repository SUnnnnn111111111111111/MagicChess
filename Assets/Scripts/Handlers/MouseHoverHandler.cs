using UnityEngine;
using UltEvents;

public class MouseHoverHandler : MonoBehaviour
{
    public bool isActive = true;
    [SerializeField] private UltEvent  OnMouseHover;
    [SerializeField] private UltEvent  OnRemovingMouseHover;
    
    
    void OnMouseEnter()
    {
        if (isActive)
            OnMouseHover.Invoke();
    }
    void OnMouseExit()
    {
        if (isActive)
            OnRemovingMouseHover.Invoke();
    }
}
