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
    public float cachedTouchPosition;
    public Vector3 StachePositionStart;

    private void Start()
    {
        StachePositionStart = StacheHolder.transform.localPosition; //Collin how can we use this to reset the stache 
    }
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Debug.Log("Touch");
            
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
              

                StacheHolder.transform.localPosition = new Vector3(StacheHolder.transform.localPosition.x, 
                    StacheHolder.transform.localPosition.y + touch.deltaPosition.y, 
                    StacheHolder.transform.localPosition.z);
            }
        }
    }

}