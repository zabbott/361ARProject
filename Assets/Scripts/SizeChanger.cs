using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DanielLochner.Assets.SimpleScrollSnap;
using UnityEngine.UI;

public class SizeChanger : MonoBehaviour
{
    public SimpleScrollSnap SSS;
    public Vector2 expandedSize;
    public Vector2 shrunkSize;
    public int MiddleItem;
    private void Awake()
    {
        SimpleScrollSnap.SetupComplete += InitialCenter;
    }
    public void Start()
    {
        SSS.GoToPanel(MiddleItem);
    }
    public void OnCentered()
    {
        SSS.Panels[SSS.CenteredPanel].sizeDelta = expandedSize;
        foreach (var panel in SSS.Panels)
        {
            if(panel == SSS.Panels[SSS.CenteredPanel])
            {
                panel.sizeDelta = expandedSize;
                //panel.GetComponent<Button>().interactable = true;
            }
            else
            {
                panel.sizeDelta = shrunkSize;
                //panel.GetComponent<Button>().interactable = false;
                Debug.Log("shrunk " + panel.name);
            }
        }
    }

    public void InitialCenter(SimpleScrollSnap comparison)
    {
        if (comparison == SSS)
        {
            foreach (var panel in SSS.Panels)
            {
                if (panel == SSS.Panels[MiddleItem])
                {
                    panel.sizeDelta = expandedSize;
                    Debug.Log("expanded " + panel.name);

                }
                else
                {
                    panel.sizeDelta = shrunkSize;
                   // panel.GetComponent<Button>().interactable = false;
                   // Debug.Log("shrunk " + panel.name);
                }
            }
        }
    }


}
