using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfirmPin : MonoBehaviour
{
    public Collider ObjToCheck;

    public bool Solved = false;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == ObjToCheck.tag)
        {

            Solved = true;


        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == ObjToCheck.tag)
        {

            Solved = false;


        }
    }
}
