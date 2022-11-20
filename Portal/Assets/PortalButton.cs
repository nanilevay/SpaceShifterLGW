using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalButton : MonoBehaviour
{
    public PortalChecker portal;
   
    public void ToggleOn()
    {
        if(portal.Occupied)
        {
            portal.Activate();
        }

        else
        {
            portal.Deactivate();
        }
    }
}
