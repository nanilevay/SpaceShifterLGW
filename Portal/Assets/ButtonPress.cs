using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPress : MonoBehaviour
{
    public bool interacting = false;

    public void Interacting()
    {
        interacting = true;
    }


    public void NotInteracting()
    {
        interacting = false;
    }




}
