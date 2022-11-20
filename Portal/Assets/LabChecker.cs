using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LabChecker : MonoBehaviour
{
    public bool inLab;
    public Collider Player;

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == Player.tag)
            inLab = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == Player.tag)
            inLab = false;
    }
}
