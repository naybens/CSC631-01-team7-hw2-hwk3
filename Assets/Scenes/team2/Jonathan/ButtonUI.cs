
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonUI : MonoBehaviour
{
    [SerializeField] private string timeOfDay = "Night";
    public Light myLight;
    public bool isDaytime = true;

public void ChangeTimeOfDay()
{
    isDaytime = !isDaytime;
    myLight.intensity = isDaytime ? 1f: 0.1f;

}

}
