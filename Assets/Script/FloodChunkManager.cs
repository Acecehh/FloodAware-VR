using System.Collections.Generic;
using UnityEngine;

public class FloodChunkManager : MonoBehaviour
{
    public Transform PlayerBoat; // Drag your boat here
    public List<Transform> chunks; // Drag your prefab instances in order
    public float chunkLength = 40f;
    private float repositionThreshold = 10f;

    void Update()
    {
        foreach (Transform chunk in chunks)
        {
            if (PlayerBoat.position.z - chunk.position.z > chunkLength + repositionThreshold)
            {
                float farthestZ = GetFarthestChunkZ();
                chunk.position = new Vector3(chunk.position.x, chunk.position.y, farthestZ + chunkLength);
            }
        }
    }

    float GetFarthestChunkZ()
    {
        float farthest = float.MinValue;
        foreach (Transform chunk in chunks)
        {
            if (chunk.position.z > farthest)
                farthest = chunk.position.z;
        }
        return farthest;
    }
}
