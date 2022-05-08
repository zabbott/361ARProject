using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARPlaneFuncs : MonoBehaviour
{
    void OnEnable()
    {
        PlacementController.OnPlaced += TurnOffPlane;
        PlacementController.OnRequestReplaced += TurnOnPlane;
    }

    public void TurnOffPlane()
    {
        gameObject.GetComponent<MeshRenderer>().enabled = false;
        gameObject.GetComponent<LineRenderer>().enabled = false;
    }

    private void OnDisable()
    {
        PlacementController.OnPlaced -= TurnOffPlane;
        PlacementController.OnRequestReplaced -= TurnOnPlane;
    }
    public void TurnOnPlane()
    {
        gameObject.GetComponent<MeshRenderer>().enabled = true;
        gameObject.GetComponent<LineRenderer>().enabled = true;
    }

}
