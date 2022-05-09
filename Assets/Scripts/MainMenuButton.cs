using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MainMenuButton : MonoBehaviour
{
    public Sprite SecondSprite;
    public Sprite FirstSprite;
    public Image MyImage;
    public Fader MyFader;
    public Animator MyAnimator;
    public int MyArt;
    public int taps; 
    public void FirstTap()
    {
        UIManager.Instance.UpdateButtons(this);
        MyImage.sprite = SecondSprite;
        taps = 1; 
    }

    public void SecondTap()
    {
        MyFader.AskUIManagerToFade();
        UIManager.Instance.UpdateArtwork(MyArt);
        UIManager.Instance.Anim.SetTrigger("ShouldExpand");
        Reset();
    }

    public void Reset()
    {
        MyImage.sprite = FirstSprite;
        taps = 0; 
    }

    public void DoTap()
    {
        if(taps == 0)
        {
            FirstTap(); 
        }
        else
        {
            SecondTap(); 
        }
    }
}
