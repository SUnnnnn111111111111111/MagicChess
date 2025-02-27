using UnityEngine;
using UltEvents;

public class Raycaster : MonoBehaviour
{
    [SerializeField] private LayerMask layerMask;
    [SerializeField] private UltEvent<Collider>  WhenRayHit;

    public void CastTheRay(Vector3 vector)
    {
        if(Physics.Raycast(transform.position, vector, out RaycastHit raycastHitInfo, vector.magnitude, layerMask))
        {
            WhenRayHit.Invoke(raycastHitInfo.collider);
        }
    }
}
