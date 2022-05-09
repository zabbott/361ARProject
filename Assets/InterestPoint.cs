using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterestPoint : MonoBehaviour
{
    public string Description;

    public void UpdateText()
    {
        UIManager.Instance.UpdateDescriptionWithText(Description); 
    }

    /*
    public void GetAudio()
    {
        UIManager.Instance.UpdateDescriptionWithAudio(clip);
    }
    */
}
