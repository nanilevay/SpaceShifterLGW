using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowDiffText : MonoBehaviour
{
    public GameObject[] textsToShow;
    public int count = 0;
    public int max = 10;

    public void ShowText()
    {
        textsToShow[count].active = false;

        count += 1;

        textsToShow[count].active = true;

        if (count == max)
        {
            textsToShow[count].active = false;
            count = 0;
        }

    }
}
