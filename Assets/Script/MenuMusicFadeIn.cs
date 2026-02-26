using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class MenuMusicFadeIn : MonoBehaviour
{
    public float fadeDuration = 2f;
    private AudioSource audioSource;
    private float targetVolume;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        targetVolume = audioSource.volume;
        audioSource.volume = 0f;
        audioSource.Play();
        StartCoroutine(FadeIn());
    }

    System.Collections.IEnumerator FadeIn()
    {
        float time = 0;
        while (time < fadeDuration)
        {
            time += Time.deltaTime;
            audioSource.volume = Mathf.Lerp(0, targetVolume, time / fadeDuration);
            yield return null;
        }
    }
}