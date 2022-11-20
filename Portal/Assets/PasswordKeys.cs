using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PasswordKeys : MonoBehaviour
{
    // text get the number

    private Renderer rend;

    // check if pressed (add the colliders)

    public bool wasPressed = false;
    public string value;
//    public TextMeshProUGUI textToChange;

    public void PressingDown()
    {
        wasPressed = true;
       
    }

    public void Releasing()
    {
        wasPressed = false;
    }




    //void OnMouseDown()
    //{
    //    wasPressed = true;
    //    textToChange.text = "Pressed key";
    //    Debug.Log("press");

    //}

    //void OnMouseUp()
    //{
    //    wasPressed = false;
    //}
}
