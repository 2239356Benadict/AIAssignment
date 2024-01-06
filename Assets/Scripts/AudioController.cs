using UnityEngine;
using UnityEngine.UI;

public class AudioController : MonoBehaviour
{
    public AudioClip[] audioClips;
    public AudioSource audioSource;
    private int currentClipIndex;
    private bool isMuted;

    public Sprite muteSprite;
    public Sprite unmuteSprite;
    private Image buttonSpriteImage;

    void Start()
    {
        currentClipIndex = 0;
        isMuted = false;

        // Set the initial audio clip
        audioSource.clip = audioClips[currentClipIndex];

    }

    void Update()
    {
        // Check for button press, for example, space key
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Play the current audio clip
            audioSource.Play();

            // Move to the next audio clip in the list
            currentClipIndex = (currentClipIndex + 1) % audioClips.Length;

            // Set the next audio clip
            audioSource.clip = audioClips[currentClipIndex];
        }

        // Check for mute/unmute button press, for example, M key
        if (Input.GetKeyDown(KeyCode.M))
        {
            ToggleMute();
        }
    }

    void ToggleMute()
    {
        isMuted = !isMuted;

        // Mute or unmute the audio
        audioSource.mute = isMuted;

        // Change the button sprite based on mute/unmute state
        if (buttonSpriteImage != null)
        {
            buttonSpriteImage.sprite = isMuted ? muteSprite : unmuteSprite;
        }
    }
}
