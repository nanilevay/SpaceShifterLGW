using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalOn : MonoBehaviour
{
    private GameObject[] redLights;

    public GameObject Blocker;

    private Animator anim;


    // Start is called before the first frame update
    private void Start()
    {
        anim = GetComponent<Animator>();

        redLights = GameObject.FindGameObjectsWithTag("EmergencyLightPortal");

        AlarmLightON();
    }


    private void AlarmLightON()
    {
        for (int i = 0; i < redLights.Length; i++)
        {
            redLights[i].GetComponent<Light>().enabled = true;

            anim = redLights[i].GetComponent<Animator>();
            anim.SetBool("IsActive", true);
        }
    }

    public void AlarmLightOFF()
    {
        Blocker.active = false;
        for (int i = 0; i < redLights.Length; i++)
        {
            redLights[i].GetComponent<Light>().enabled = false;

            anim = redLights[i].GetComponent<Animator>();
            anim.SetBool("IsActive", false);
        }
    }
}
