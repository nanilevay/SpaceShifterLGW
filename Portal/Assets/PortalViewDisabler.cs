using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalViewDisabler : MonoBehaviour
{
    public Collider Player;

    public GameObject ObjsToDisable;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == Player.tag)
        {
            ObjsToDisable.SetActive(false);
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.tag == Player.tag)
        {
            ObjsToDisable.SetActive(true);
        }
    }
}
