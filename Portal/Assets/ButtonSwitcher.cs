using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSwitcher : MonoBehaviour
{
    public GameObject objToSwitch;

    public void Switch()
    {
        if (objToSwitch.activeSelf)
            objToSwitch.SetActive(false);

        else
            objToSwitch.SetActive(true);
    }
}
