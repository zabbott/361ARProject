using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DanielLochner.Assets.SimpleScrollSnap;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;
    public float FadeSpeed;
    public Sprite SelectedStache;
    public SimpleScrollSnap Snap;
    public float BigSize; 
    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void CallFade(CanvasGroup FadeOut, CanvasGroup FadeIn)
    {
        StartCoroutine(Fade(FadeOut, FadeIn));
    }
  
    public IEnumerator Fade(CanvasGroup FadeOut, CanvasGroup FadeIn)
    {
        FadeOut.interactable = false;
        FadeIn.interactable = false;
        FadeOut.blocksRaycasts = false;
        FadeIn.blocksRaycasts = false;
        while (FadeOut.alpha > 0 || FadeIn.alpha < 1)
        {
            FadeOut.alpha -= FadeSpeed * Time.deltaTime;
            FadeIn.alpha += FadeSpeed * Time.deltaTime;
            yield return null;
        }
        FadeIn.interactable = true;
        FadeIn.blocksRaycasts = true;
    }

    public void Centered()
    {
       var centeredPanel = Snap.Panels[Snap.CenteredPanel];
       for(snap)
    }

    public void Embigginator()
    {

    }
}

