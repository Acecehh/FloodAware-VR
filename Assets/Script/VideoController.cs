using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.EventSystems;

public class VideoController : MonoBehaviour, IPointerClickHandler
{
    public VideoPlayer videoPlayer;
    public Button playButton; // This button holds the Play icon (Image)
    public GameObject playIcon; // The icon inside the button (optional)

    void Start()
    {
        // Start paused
        videoPlayer.Pause();

        // Show play button initially
        ShowPlayButton(true);

        // Button click starts the video and hides the icon
        playButton.onClick.AddListener(() => {
            videoPlayer.Play();
            ShowPlayButton(false);
        });
    }

    // When clicking the video display
    public void OnPointerClick(PointerEventData eventData)
    {
        if (videoPlayer.isPlaying)
        {
            videoPlayer.Pause();
            ShowPlayButton(true);
        }
        else
        {
            videoPlayer.Play();
            ShowPlayButton(false);
        }
    }

    // Show or hide the play button/icon
    void ShowPlayButton(bool show)
    {
        playButton.gameObject.SetActive(show);
    }
}
