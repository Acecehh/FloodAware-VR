using UnityEngine;
using UnityEngine.UI;

public class BoxPlacer : MonoBehaviour
{
    public string placementTag = "PlacementSurface";
    public GameObject placementText; // Assign a UI Text or World Space Text in Inspector

    private bool isPlaced = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(placementTag) && !isPlaced)
        {
            // Snap to surface
            Vector3 newPos = other.transform.position + new Vector3(0, transform.localScale.y / 2, 0); // Adjust Y offset
            transform.position = newPos;

            isPlaced = true;

            // Show placement text
            if (placementText != null)
                placementText.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(placementTag))
        {
            isPlaced = false;

            // Hide text when moved away
            if (placementText != null)
                placementText.SetActive(false);
        }
    }
}
