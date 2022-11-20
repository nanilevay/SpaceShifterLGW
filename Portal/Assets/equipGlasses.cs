using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class equipGlasses : MonoBehaviour
{
    public GameObject Glasses;

    public GameObject Filter;

    private void Start()
    {
        Filter.active = false;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Hands")
        {
            if (!Glasses.active)

            {
                if (!Filter.active)

                {
                    Filter.active = true;

                }


                else

                {
                    Filter.active = false;

                }
            }
        }

    }

        private void OnTriggerStay(Collider other)
    {

        
        if (other.tag == "Glasses")
        {
            Glasses.active = false;
            Filter.active = true;
        }


       
    }
}
