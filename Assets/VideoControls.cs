using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoControls : MonoBehaviour
{
    public VideoPlayer vp;
   
    public void PlayPause()
    {
        if (vp.isPlaying)
        {
            vp.Pause(); 
        }
        else
        {
            vp.Play();
        }
    }
}
