using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneButton : MonoBehaviour
{
    // You can set the scene name from the Inspector
    public string sceneToLoad;

    // Call this method from your button's OnClick() event
    public void LoadScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
