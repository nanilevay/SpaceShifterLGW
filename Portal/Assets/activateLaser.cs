using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateLaser : MonoBehaviour
{
    public GameObject Filter;
    public GameObject Light;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Filter.active)
        {
            Light.active = true;
        }

        else
        {
            Light.active = false;
        }
    }
}
