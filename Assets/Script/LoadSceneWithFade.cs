using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadSceneWithFade : MonoBehaviour
{
    [Header("Start Button")]
    public Button startButton;

    [Header("Fade Settings")]
    public FadeScreen fadeScreen;
    public string startSceneName = "1 Start Scene"; // Replace with your actual scene name

    void Start()
    {
        startButton.onClick.AddListener(OnStartButtonClicked);
    }

    private void OnStartButtonClicked()
    {
        StartCoroutine(FadeAndLoadScene());
    }

    private IEnumerator FadeAndLoadScene()
    {
        fadeScreen.FadeOut();
        yield return new WaitForSeconds(fadeScreen.fadeDuration);
        SceneManager.LoadScene(startSceneName);
    }
}
