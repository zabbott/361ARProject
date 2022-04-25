using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ReturnToHomePage : MonoBehaviour
{
    public CanvasGroup[] NotHomePage;
    public CanvasGroup HomePage;
    public GameObject nothingPage; 

    public void GoToHomePage()
    {
        foreach(var item in NotHomePage)
        {
            item.alpha = 0;
            item.blocksRaycasts = false;
            item.interactable = false; 
        }

        HomePage.alpha = 1;
        HomePage.interactable = true;
        HomePage.blocksRaycasts = true;
        nothingPage.SetActive(false); 
    }
}
