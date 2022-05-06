using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbientSound : MonoBehaviour
{
    public AudioClip AmbientAudio;
    private AudioSource Audio;

    void Start()
    {
        Audio = GetComponent<AudioSource>();
        Audio.clip = AmbientAudio;
        Audio.loop = true;
        Audio.Play();
    }
}
