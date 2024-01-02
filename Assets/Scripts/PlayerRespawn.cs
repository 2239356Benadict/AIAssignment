using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerRespawn : MonoBehaviour
{
    public Transform spawnPoint;
    public KeyCode respawnButton = KeyCode.R;
    public float respawnDuration = 1.5f; // Adjust the duration as needed
    public Transform playerCamera; // Assign your player camera here
    public Image fadePanel; // Reference to a UI Image component for the fade effect
    private bool isRespawning = false;

    void Start()
    {
        // Ensure the fade panel is initially set to completely transparent
        if (fadePanel != null)
        {
            Color initialColor = fadePanel.color;
            initialColor.a = 0f;
            fadePanel.color = initialColor;
        }
    }

    void Update()
    {
        if (!isRespawning && Input.GetKeyDown(respawnButton))
        {
            StartCoroutine(RespawnCoroutine());
        }
    }

    IEnumerator RespawnCoroutine()
    {
        isRespawning = true;

        if (spawnPoint != null && playerCamera != null && fadePanel != null)
        {
            // Fade out
            StartCoroutine(FadeOut(fadePanel, respawnDuration / 2f));

            // Wait for the fade-out to complete
            yield return new WaitForSeconds(respawnDuration / 2f);

            // Teleport the player and camera to the spawn point
            transform.position = spawnPoint.position;
            transform.rotation = spawnPoint.rotation;
            playerCamera.position = spawnPoint.position;
            playerCamera.rotation = spawnPoint.rotation;

            // Fade in
            StartCoroutine(FadeIn(fadePanel, respawnDuration / 2f));

            // Wait for the fade-in to complete
            yield return new WaitForSeconds(respawnDuration / 2f);
        }
        else
        {
            Debug.LogError("Spawn point, player camera, or fade panel not set!");
        }

        isRespawning = false;
    }

    IEnumerator FadeOut(Image panel, float duration)
    {
        float elapsedTime = 0f;
        Color panelColor = panel.color;

        while (elapsedTime < duration)
        {
            panelColor.a = Mathf.Lerp(0f, 1f, elapsedTime / duration);
            panel.color = panelColor;

            elapsedTime += Time.deltaTime;
            yield return null;
        }

        panelColor.a = 1f;
        panel.color = panelColor;
    }

    IEnumerator FadeIn(Image panel, float duration)
    {
        float elapsedTime = 0f;
        Color panelColor = panel.color;

        while (elapsedTime < duration)
        {
            panelColor.a = Mathf.Lerp(1f, 0f, elapsedTime / duration);
            panel.color = panelColor;

            elapsedTime += Time.deltaTime;
            yield return null;
        }

        panelColor.a = 0f;
        panel.color = panelColor;
    }
}
