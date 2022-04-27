using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fader : MonoBehaviour
{
    public CanvasGroup GroupToFadeOut;
    public bool JustFadeIn;
    public bool JustFadeOut;
    public CanvasGroup GroupToFadeIn;
    public void AskUIManagerToFade()
    {
        UIManager.Instance.CallFade(GroupToFadeOut, GroupToFadeIn);
    }
}
