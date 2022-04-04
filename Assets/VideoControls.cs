using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoControls : MonoBehaviour
{
    public VideoPlayer player; 
    public void TogglePlayPause()
    {
        if (player.isPlaying)
        {
            player.Pause(); 
        }
        else
        {
            player.Play();
        }
    }
}
