using UnityEngine;
using UnityEngine.EventSystems;

public class UnSelectBtn : MonoBehaviour
{
    public void DeselectButton() {
        EventSystem.current.SetSelectedGameObject(null);
    }

}
