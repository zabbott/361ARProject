using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class UIManager : MonoBehaviour
{
    public static UIManager Instance;
    public float FadeSpeed;
    public CanvasGroup[] characterMenus;
    public CanvasGroup mainMenu;
    public CanvasGroup errorPage; 
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

    public void FadeCharactersToMainMenu()
    {
      
        foreach(var screen in characterMenus)
        {
            screen.alpha = 0;
            screen.interactable = false;
            screen.blocksRaycasts = false; 
        }
        StartCoroutine(Fade( characterMenus[0], mainMenu));
       
    }

    public void FadeCharactersToErrorPage()
    {

        foreach (var screen in characterMenus)
        {
            screen.alpha = 0;
            screen.interactable = false;
            screen.blocksRaycasts = false;
        }
        StartCoroutine(Fade(characterMenus[0], errorPage));

    }
}

