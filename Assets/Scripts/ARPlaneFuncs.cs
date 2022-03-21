using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARPlaneFuncs : MonoBehaviour
{
    void OnEnable()
    {
        PlacementController.OnPlaced += TurnOffPlane;
    }

    public void TurnOffPlane()
    {
        gameObject.SetActive(false);  
    }

    private void OnDisable()
    {
        PlacementController.OnPlaced -= TurnOffPlane;
    }
}
