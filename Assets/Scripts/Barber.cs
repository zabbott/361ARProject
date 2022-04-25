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

    public SimpleScrollSnap Snap;

    public void Barbershop()
    {
        Staches[] = UImanager.centerPanel;
        StacheNames[] = UImanager.centerPanel;
        StacheDescriptions[] = UImanager.centerPanel;

        SelectedStache = Staches[];
        SelectedStache = StacheNames[];
        SelectedStache = StacheDescriptions[];
    }


}
