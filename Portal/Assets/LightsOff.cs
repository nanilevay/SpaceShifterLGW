using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsOff : MonoBehaviour
{
    private GameObject[] lights;
    // Start is called before the first frame update
    void Start()
    {
        lights = GameObject.FindGameObjectsWithTag("LabLights");
    }

    public void SwitchOffLight()
    {
        if (lights[0].GetComponent<Light>().enabled)
        {
            for (int i = 0; i < lights.Length; i++)
            {
                lights[i].GetComponent<Light>().enabled = false;
            }
        }


        else
        {
            for (int i = 0; i < lights.Length; i++)
            {
                lights[i].GetComponent<Light>().enabled = true;
            }
        }
    }
}
