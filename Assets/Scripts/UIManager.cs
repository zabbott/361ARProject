using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class UIManager : MonoBehaviour
{
    public static UIManager Instance;
    public float FadeSpeed;
    public Animator appAnimator;
    public GameObject[] WandaContent; // 0
    public GameObject[] ShangChiContent; // 1
    public GameObject[] ThorContent; // 2

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

    public void ToggleContent(int whichOne)
    {
        if(whichOne == 0)
        {
            for(int i = 0; i < WandaContent.Length; i++)
            {
                WandaContent[i].gameObject.SetActive(true);
                ShangChiContent[i].gameObject.SetActive(false);
                ThorContent[i].gameObject.SetActive(false);


            }
        }
        else if (whichOne == 1)
        {
            for (int i = 0; i < WandaContent.Length; i++)
            {
                WandaContent[i].gameObject.SetActive(false);
                ShangChiContent[i].gameObject.SetActive(true);
                ThorContent[i].gameObject.SetActive(false);


            }
        }
        else if (whichOne == 2)
        {
            for (int i = 0; i < WandaContent.Length; i++)
            {
                WandaContent[i].gameObject.SetActive(false);
                ShangChiContent[i].gameObject.SetActive(false);
                ThorContent[i].gameObject.SetActive(true);


            }
        }
        appAnimator.SetTrigger("Shrink");
    }
    public void Return()
    {
     
            for (int i = 0; i < WandaContent.Length; i++)
            {
                WandaContent[i].gameObject.SetActive(false);
                ShangChiContent[i].gameObject.SetActive(false);
                ThorContent[i].gameObject.SetActive(false);


            }
       
        appAnimator.SetTrigger("Expand");
    }
}

