using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Icon : MonoBehaviour
{
    public string Name;
    public Sprite art;
    public Button myButton;
    public string classText;
    public static Action<Sprite, string> iconSelected; 
    private void OnEnable()
    {
        ScrollViewUpdater.TogglebuttonInteraction += Toggle;
        Name = gameObject.name; 
        myButton = gameObject.GetComponent<Button>();
        myButton.onClick.AddListener(() => UpdateDetails());
    
    }
    public void UpdateDetails()
    {
        iconSelected?.Invoke(art, classText);
    }
    public void Toggle(bool status)
    {
        myButton.interactable = status;
    }
    private void OnDisable()
    {
        ScrollViewUpdater.TogglebuttonInteraction -= Toggle;

    }


}
