using UnityEngine;

public class BoatMovement : MonoBehaviour
{
    public float moveSpeed = 4f;
    public float floatAmplitude = 0.2f;
    public float floatFrequency = 1f;

    private float startY;

    void Start()
    {
        startY = transform.position.y;
    }

    void Update()
    {
        // Move forward based on boat's UP direction (adjust for your rotation)
        transform.position += -transform.right * moveSpeed * Time.deltaTime;


        // Optional: floating effect
        float newY = startY + Mathf.Sin(Time.time * floatFrequency) * floatAmplitude;
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}
