using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu_controls : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject menu;
  public void toggleword()
    {
        menu.SetActive(!menu.activeSelf);
    }
}
