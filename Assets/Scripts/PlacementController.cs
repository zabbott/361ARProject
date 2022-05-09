using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.UI;
public class PlacementController : MonoBehaviour
{
    public Camera ARCamera;
    public GameObject target;
    public ARPlaneManager ARPM;
    public float yOffset;
    public static event Action OnPlaced;
    public static event Action OnRequestReplaced;
    public Button PlaceButton;
    public GameObject currentbanner;
    public GameObject[] banners;
    public GameObject[] replacebutton;
    private int index;
    public bool startscanning;


    private void Start()
    {
        index = 0;
        currentbanner = banners[0];
    }

    private void Update()
    {
        if (startscanning)
        {

        
        Ray ray = ARCamera.ScreenPointToRay(new Vector2(Screen.width / 2, Screen.height / 2));
        RaycastHit hitObject;
        if (Physics.Raycast(ray, out hitObject))
        {
            PlaceButton.interactable = true;
            target.SetActive(true);
            target.transform.position = new Vector3( hitObject.point.x, hitObject.point.y - yOffset, hitObject.point.z);
        }
        else
        {
        }
        }
    }
    public void PlaceObject()
    {
        OnPlaced?.Invoke();
        currentbanner.gameObject.SetActive(true);
        currentbanner.GetComponent<LookAtPlayer>().timer = 1f;
        currentbanner.transform.position = target.transform.position;
        target.SetActive(false); 
        PlaceButton.gameObject.SetActive(false);
        ARPM.enabled = false;
        replacebutton[index].SetActive(true);
    }
    public void switchbanner(int number)
    {
        PlaceButton.gameObject.SetActive(true);
        currentbanner = banners[number];
        index = number;
        if (currentbanner.activeInHierarchy)
        {
            foreach(GameObject obj in replacebutton)
            {
                obj.SetActive(false);
            }
            replacebutton[number].SetActive(true);
            PlaceButton.gameObject.SetActive(false);
        }
        else
        {
            foreach (GameObject obj in replacebutton)
            {
                obj.SetActive(false);
            }
            PlaceButton.gameObject.SetActive(true);
        }

    }
    public void toggleScanning(bool state)
    {
        startscanning = state;
        if (state == true)
        {
            ARPM.enabled = true;
            target.SetActive(true);
        }
    }
}
