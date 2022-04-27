using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ColorChanger : MonoBehaviour
{
    public Image[] buttons;
    public Color activecolor;
    public Color inactivecolor;

    public void ChangeColor(Image active)
    {
        foreach (Image img in buttons)
        {
            img.color = inactivecolor;

        }
        active.color = activecolor;

    }
}
