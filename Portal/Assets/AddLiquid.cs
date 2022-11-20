using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddLiquid : MonoBehaviour
{
    bool InArea = false;

   void OnTriggerStay(Collider Col)
    {
        if(Col.tag == "TestTube" && this.tag == "TestTube" && InArea)
        {
            
            Col.GetComponentInChildren<Animator>().SetBool("Filling", true);
            this.GetComponentInChildren<Animator>().SetBool("Filling", false);
        }
    }


    void Update()

    { 
        if (Input.GetMouseButtonDown(1))
	    {
            InArea = true;
        }

        else
        {
            InArea = false;
        }
    }
}
