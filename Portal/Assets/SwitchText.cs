using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SwitchText : MonoBehaviour
{
    private bool isGazingUpon;

    public GameObject[] textsToShow;
    public int count = 0;
    public int max = 10;
    private bool once;

    public void ShowText()
    {
        once = true;

        
    }


    void Update()
    {

        if (once && isGazingUpon)
        {
            textsToShow[count].active = false;

            count += 1;

            textsToShow[count].active = true;

            if (count == max)
            {
                textsToShow[count].active = false;
                count = 0;
            }
            once = false;
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
