using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalChecker : MonoBehaviour
{
    public bool Occupied = false;
    public Collider PortalCube;
    public GameObject Portal;

    public void OnTriggerStay(Collider other)
    {
        if (other.tag == PortalCube.tag)
        {
            Occupied = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.tag == PortalCube.tag)
        {
            Occupied = false;
        }
    }

    public void Activate()
    {
        Portal.SetActive(!Portal.activeSelf);
    }

    public void Deactivate()
    {
        Portal.SetActive(false);
    }
}
