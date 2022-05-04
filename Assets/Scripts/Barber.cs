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

    public GameObject StacheHolder;
    private float height;
    private Vector2 StacheHeight;

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Debug.Log("Touch");

            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                Vector2 pos = touch.position;
                pos.y = (pos.y - height) / height;
                StacheHeight = new Vector2(StacheHolder.transform.position.x, pos.y);

                StacheHolder.transform.position = StacheHeight;
            }
        }
    }

}