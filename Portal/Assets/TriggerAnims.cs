using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAnims : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Anim")
        {
            other.GetComponent<Animator>().SetBool("Activate", true);
        }
    }

    //When the Primitive exits the collision, it will change Color
    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Anim")
        {
            other.GetComponent<Animator>().SetBool("Activate", false);
        }
    }
}
