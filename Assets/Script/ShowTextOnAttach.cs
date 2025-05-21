using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class ShowTextOnAttach : MonoBehaviour
{
    public GameObject textToShow; // Assign the text object in inspector
    private XRSocketInteractor socketInteractor;

    private void Awake()
    {
        socketInteractor = GetComponent<XRSocketInteractor>();
    }

    private void OnEnable()
    {
        socketInteractor.selectEntered.AddListener(ShowText);
        socketInteractor.selectExited.AddListener(HideText);
    }

    private void OnDisable()
    {
        socketInteractor.selectEntered.RemoveListener(ShowText);
        socketInteractor.selectExited.RemoveListener(HideText);
    }

    private void ShowText(SelectEnterEventArgs args)
    {
        if (textToShow != null)
            textToShow.SetActive(true);
    }

    private void HideText(SelectExitEventArgs args)
    {
        if (textToShow != null)
            textToShow.SetActive(false);
    }
}
