using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class SpecificObjectSocket : XRSocketInteractor
{
    [Tooltip("Only this object will be accepted by the socket.")]
    public XRGrabInteractable allowedObject;  // Drag the allowed object or prefab here

    public override bool CanSelect(IXRSelectInteractable interactable)
    {
        // Check if the object is the one we want to allow
        return base.CanSelect(interactable) && interactable.transform == allowedObject.transform;
    }
}
