using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Cinemachine;


public class ChangeCamera : MonoBehaviour
{
    public CinemachineVirtualCamera PlayerFollowCamera;
    public CinemachineVirtualCamera TopDownCamera;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (PlayerFollowCamera.enabled)
            {
                PlayerFollowCamera.enabled = false;
                TopDownCamera.enabled = true;
            }
            else
            {
                PlayerFollowCamera.enabled = true;
                TopDownCamera.enabled = false;
            }
        }
    }

}


