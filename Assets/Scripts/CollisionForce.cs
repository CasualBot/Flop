using UnityEngine;

public class CollisionForce : MonoBehaviour
{
    private float magnitude = 10000f;
    void OnCollisionEnter(Collision other)
    {
        Vector3 force = transform.position - other.transform.position;
        force.Normalize();
        gameObject.GetComponent<Rigidbody>().AddForce(-force * magnitude);
    }
}
