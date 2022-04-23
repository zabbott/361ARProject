using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAnimator : MonoBehaviour
{
    public Animator MyAnimator; 

    public void Expand()
    {
        MyAnimator.SetTrigger("Expand"); 
    }

    public void Shrink()
    {
        MyAnimator.SetTrigger("Shrink");
    }
}
