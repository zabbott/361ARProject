using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DetailsPage : MonoBehaviour
{
    public Image classImage;
    public TMP_Text classText;

    private void OnEnable()
    {
        Icon.iconSelected += UpdateStuff;
    }
    public void UpdateStuff(Sprite art, string text)
    {
        classImage.sprite = art;
        classText.text = text;
    }
    private void OnDisable()
    {
        Icon.iconSelected -= UpdateStuff;
    }
}
