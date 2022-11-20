using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knobCheck : MonoBehaviour
{

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "bolt")
        {
            this.GetComponent<Rigidbody>().isKinematic = true;
            this.GetComponent<Rigidbody>().useGravity = false;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "bolt")
        {
            this.GetComponent<Rigidbody>().isKinematic = false;
            this.GetComponent<Rigidbody>().useGravity = true;
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

  
}
