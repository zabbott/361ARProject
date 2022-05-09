using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip one;
    public AudioClip two;
    public AudioClip three;
    public AudioClip four;

    AudioSource audio;

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    public void PlaySound(string audioName)
    {
        switch (audioName)
        {
            case "one":
                audio.clip = one;
                break;
            case "two":
                audio.clip = two;
                break;
            case "three":
                audio.clip = three;
                break;
            case "four":
                audio.clip = four;
                break;
        }
        audio.Play();
    }

    public void PauseSound()
    {
        audio.Stop();
    }
}
