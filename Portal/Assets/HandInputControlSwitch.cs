using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandInputControlSwitch : MonoBehaviour
{

    public GameObject handTrackingLeft;
    public GameObject handTrackingRight;

    public GameObject controllerLeft;
    public GameObject controllerRight;

    private void Update()
    {
        if (OVRPlugin.GetHandTrackingEnabled())
        {
            handTrackingLeft.SetActive(true);
            handTrackingRight.SetActive(true);

            controllerLeft.SetActive(false);
            controllerRight.SetActive(false);
        }

        else
        {
            handTrackingLeft.SetActive(false);
            handTrackingRight.SetActive(false);

            controllerLeft.SetActive(true);
            controllerRight.SetActive(true);
        }

    }
}
