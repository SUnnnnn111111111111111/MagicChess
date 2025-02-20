using UnityEngine;

public class RigidbodyPusher : MonoBehaviour
{
    [SerializeField] private Rigidbody rigidBody;
    [SerializeField] private ForceMode forceMode;

    public void Push(float force, Vector3 vector3)
    {
        rigidBody.AddForce(vector3.normalized * force, forceMode);
    }
}
