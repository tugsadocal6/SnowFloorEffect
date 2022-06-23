using UnityEngine;

public class PhysicsDeformer : MonoBehaviour
{
    [SerializeField] private float collisionRadius = 0.1f;
    [SerializeField] private DeformableMesh deformableMesh;
    void OnCollisionStay(Collision collision)
    {
        foreach (var contact in collision.contacts)
            deformableMesh.AddDepression(contact.point, collisionRadius);
    }
}