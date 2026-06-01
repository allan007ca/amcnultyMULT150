using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioLooper : MonoBehaviour
{
    public AudioSource audioSource;

    void Start()
    {
        if (audioSource != null)
        {
            audioSource.loop = true;
            // We don't call audioSource.Play() here anymore, 
            // because the visibility functions below will handle it.
        }
        else
        {
            Debug.LogWarning("Please assign an AudioSource to the LoopAudio script!");
        }
    }

    // Automatically triggers when the cat enters the camera's view
    void OnBecameVisible()
    {
        if (audioSource != null && !audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }

    // Automatically triggers when the cat completely leaves the camera's view
    void OnBecameInvisible()
    {
        if (audioSource != null && audioSource.isPlaying)
        {
            audioSource.Stop();
        }
    }
}