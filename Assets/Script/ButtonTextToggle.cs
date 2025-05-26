using UnityEngine;
using UnityEngine.UI;

public class VRUIButtonTextToggle : MonoBehaviour
{
    public GameObject textToToggle;
    public Button vrButton;

    void Start()
    {
        if (vrButton != null)
        {
            vrButton.onClick.AddListener(ToggleText);
        }
    }

    public void ToggleText()
    {
        if (textToToggle != null)
        {
            bool isActive = textToToggle.activeSelf;
            textToToggle.SetActive(!isActive);
        }
    }
}
