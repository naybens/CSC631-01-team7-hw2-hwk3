using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLight : MonoBehaviour
{
    public Light directionLight;

    public void OnButtonClick()
    {
        directionLight.transform.Rotate(0, 90, 0);
    }
}
