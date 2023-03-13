using UnityEngine;

public class ButtonUI : MonoBehaviour
{
    public Light myLight;
    public bool isDaytime = true;

public void ChangeTimeOfDay()
{

    isDaytime = !isDaytime;
    myLight.intensity = isDaytime ? 1f: 0.1f;

}

}
