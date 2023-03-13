using UnityEngine;

public class materialSwitch : MonoBehaviour
{
    public Material[] materials;
    public GameObject cylinder;
 void Update () {
 
           if (Input.GetButtonDown("qKey")){
 
                cylinder.GetComponent<MeshRenderer>().material = materials[1];
           }
 }

}
