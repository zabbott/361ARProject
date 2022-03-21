using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
    public GameObject UserCamera;
    public float timer; 
    // Start is called before the first frame update
    void Update()
    {
        while (timer > 0)
        {
            timer -= Time.deltaTime;
            transform.LookAt(UserCamera.transform.position);
            transform.eulerAngles = new Vector3(0, transform.rotation.eulerAngles.y, 0);
        }
    }
}
