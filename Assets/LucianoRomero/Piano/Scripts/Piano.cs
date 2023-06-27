using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piano : MonoBehaviour
{
    public AudioSource audioSource; // Asigna aquí tu componente AudioSource

    public void PlayNote(AudioClip clip)
    {
        audioSource.clip = clip;
        audioSource.Play();
    }
}
