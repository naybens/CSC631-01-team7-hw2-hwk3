using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonTextChanger : MonoBehaviour
{

    public Text title;

    public void OnButtonClick(string btext)
        {
            title.text = btext;
        }
}
