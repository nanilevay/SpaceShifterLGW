using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TestObject : MonoBehaviour
{
    public bool isGazingUpon;
    public Outline outlineScript;
    
    // public TextMeshProUGUI textToChange;
    // public string givenText;

    void Update()
    {
            if (isGazingUpon)
            {
                // Do anything you want here, we'll rotate for this demo
                // transform.Rotate(0, 3, 0);
                outlineScript.enabled = true;
                // textToChange.text = givenText;

            }

            else
            {
                outlineScript.enabled = false;
                //textToChange.text = " ";
            }
       
    }

    public void GazingUpon()
    {
        isGazingUpon = true;
    }

    public void NotGazingUpon()
    {
        isGazingUpon = false;
    }
}
