using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DanielLochner.Assets.SimpleScrollSnap;

public class Barber : MonoBehaviour
{
    public Image SelectedStache;
    public TMP_Text StacheName;
    public TMP_Text Description;

    public Sprite[] Staches;
    public string[] StacheNames;
    public string[] StacheDescriptions;

    public int MiddleItem;

    public void UpdateStacheInfo(int centeredPanel)
    {
        SelectedStache.sprite = Staches[centeredPanel];
        StacheName.text = StacheNames[centeredPanel];
        Description.text = StacheDescriptions[centeredPanel];

    }


}
