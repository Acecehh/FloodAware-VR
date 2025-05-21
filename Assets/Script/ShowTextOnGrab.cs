using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class ShowTextOnGrab : MonoBehaviour
{
    public GameObject descriptionText;

    private XRGrabInteractable grabInteractable;

    void Awake()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();

        grabInteractable.selectEntered.AddListener(OnGrab);
        grabInteractable.selectExited.AddListener(OnRelease);
    }

    void OnGrab(SelectEnterEventArgs args)
    {
        if (descriptionText != null)
            descriptionText.SetActive(true);
    }

    void OnRelease(SelectExitEventArgs args)
    {
        if (descriptionText != null)
            descriptionText.SetActive(false);
    }

    private void OnDestroy()
    {
        // Cleanup listeners to avoid memory leaks
        grabInteractable.selectEntered.RemoveListener(OnGrab);
        grabInteractable.selectExited.RemoveListener(OnRelease);
    }
}
