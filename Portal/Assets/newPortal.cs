using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newPortal : MonoBehaviour
{

    public GameObject self;
    public GameObject Hand1;
    public GameObject Hand2;
    public GameObject Pocket1;
    public GameObject Pocket2;
    public Transform NextPosition;

    private void OnTriggerEnter(Collider other)
    {


        if (other.tag == "Hands")
        {
  
                //Hand1.active = false;
                //Hand2.active = false;
                Pocket1.active = false;
                Pocket2.active = false;

                self.transform.position = NextPosition.position;

                //Hand1.active = true;
                //Hand2.active = true;
                Pocket1.active = true;
                Pocket2.active = true;
 

        }
    }
}
