using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DanielLochner.Assets.SimpleScrollSnap;
using TMPro;
using System;

public class ScrollViewUpdater : MonoBehaviour
{
    public List<Icon> names;
    public SimpleScrollSnap SimpleScroll;
    public TMP_Text titleText;
    public Animator animator; 
    public static Action <bool> TogglebuttonInteraction;
    private void OnEnable()
    {
        Icon.iconSelected += IconClicked;

    }

    private void OnDisable()
    {
        Icon.iconSelected -= IconClicked;

    }
    public void OnScrollViewChanged()
    {
       titleText.text = names[SimpleScroll.SelectedPanel].name;
    }
    public void OnScrollViewMoved()
    {
        TogglebuttonInteraction(false);
        titleText.text = "";
    }
    public void OnScrollViewSettled()
    {
        TogglebuttonInteraction(true);

    }

    public void IconClicked(Sprite sprite, string text)
    {
        animator.SetTrigger("Selected");
    }
    public void Return()
    {
        animator.SetTrigger("BackToSelect");

    }
}
