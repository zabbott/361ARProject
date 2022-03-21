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
    public Button PlaceButton;
    public GameObject item;
    private void Update()
    {
        Ray ray = ARCamera.ScreenPointToRay(new Vector2(Screen.width / 2, Screen.height / 2));
        RaycastHit hitObject;
        if (Physics.Raycast(ray, out hitObject))
        {
            PlaceButton.interactable = true;
            target.SetActive(true);
            target.transform.position = new Vector3( hitObject.point.x, hitObject.point.y + yOffset, hitObject.point.z);
        }
        else
        {
        }
    }
    public void PlaceObject()
    {
        OnPlaced?.Invoke();
        item.gameObject.SetActive(true);
        item.transform.position = target.transform.position;
        target.SetActive(false); 
        PlaceButton.gameObject.SetActive(false);
        ARPM.enabled = false;
    }
  
}
