using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitch : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;
    public int manage;

    void Update()
    {
        if (Input.GetButtonDown("eKey")) {
            if (manage == 1) {
                manage = 0;
            }
            else {
                manage += 1;
            }
            StartCoroutine (CameraSwitch());
        }
        
    }

    IEnumerator CameraSwitch () {
        yield return new WaitForSeconds (0.01f);
        if(manage == 0) {
            cam1.SetActive(true);
            cam2.SetActive(false);
        }
        if(manage == 1) {
            cam1.SetActive(false);
            cam2.SetActive(true);
        }
    }
}
