using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectContent : MonoBehaviour
{
   public void TellUIManagerWhatToTurnOn(int whatToTurnOn)
    {
        UIManager.Instance.ToggleContent(whatToTurnOn);
    }
}
