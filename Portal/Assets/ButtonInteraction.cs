using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonInteraction : MonoBehaviour
{

    public bool Interact;

    public void PressingDown()
    {
        Interact = true;
    }

    public void PressingUp()
    {
        Interact = false;
    }

    //void OnMouseDown()
    //{
    //    Interact = true;
    //}


    //void OnMouseUp()
    //{
    //    Interact = false;
    //}
}
