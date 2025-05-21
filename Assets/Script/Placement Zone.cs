using UnityEngine;

public class PlacementZone : MonoBehaviour
{
    public GameObject previewObject; // Assign ghost preview box
    public GameObject labelText;     // Optional text/icon to display
    public string expectedTag = "StorageBox"; // Tag for correct object

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(expectedTag))
        {
            if (previewObject != null)
                previewObject.SetActive(true);

            if (labelText != null)
                labelText.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(expectedTag))
        {
            if (previewObject != null)
                previewObject.SetActive(false);

            if (labelText != null)
                labelText.SetActive(false);
        }
    }
}
