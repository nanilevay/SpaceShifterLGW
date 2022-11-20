using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHologram : MonoBehaviour
{
    public GameObject ShowObject;

    public void ShowOrHide()
    {
        if (ShowObject.active)
            ShowObject.active = false;

        else 
            ShowObject.active = true;

    }

}
