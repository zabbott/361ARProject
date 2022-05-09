using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class UIManager : MonoBehaviour
{
    public static UIManager Instance;
    public float FadeSpeed;
    public TMP_Text TitleText;
    public TMP_Text DescriptionText;
    public Artwork[] Arts;
    public MainMenuButton[] Buttons;
    public AudioSource source;
    public Animator Anim;

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

    public void UpdateTitleText()
    {
        TitleText.text = ""; 
    }

    public void UpdateArtwork(int WhichArtwork)
    {
        for(int i =0; i < Arts.Length; i++)
        {
            if( i == WhichArtwork)
            {
                TitleText.text = Arts[i].MyTitle;
                Arts[i].Scroller.horizontalNormalizedPosition = 0;
                Arts[i].gameObject.SetActive(true); 
            }
            else
            {
                Arts[i].gameObject.SetActive(false);
            }
        }
    }

    public void UpdateButtons(MainMenuButton buttonTapped)
    {
        foreach(var item in Buttons)
        {
            if(item != buttonTapped)
            {
                item.Reset();  
            }
        }
    }

    public void UpdateDescriptionWithText(string Text)
    {
        DescriptionText.text = Text;
    }

    public void UpdateDescriptionWithAudio(AudioClip Clip)
    {
        source.PlayOneShot(Clip);
    }

}

