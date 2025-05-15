using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BoatMover : MonoBehaviour
{
    public float speed = 30f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + transform.forward * speed * Time.fixedDeltaTime);
        Debug.Log("Moving");

    }
}

