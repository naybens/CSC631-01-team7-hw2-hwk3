using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTopAndBehind : MonoBehaviour {
    public Camera mainCamera;
    public Camera camera1;
    public Camera camera2;

    private Camera currentCamera;

    void Start()
    {
        mainCamera.enabled = true;
        camera1.enabled = false;
        camera2.enabled = false;
        currentCamera = mainCamera;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (currentCamera == mainCamera)
            {
                mainCamera.enabled = false;
                camera1.enabled = true;
                currentCamera = camera1;
            }
            else if (currentCamera == camera1)
            {
                camera1.enabled = false;
                camera2.enabled = true;
                currentCamera = camera2;
            }
            else
            {
                camera2.enabled = false;
                camera1.enabled = true;
                currentCamera = camera1;
            }
        }
    }
}
