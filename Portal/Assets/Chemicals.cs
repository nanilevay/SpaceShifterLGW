using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Chemicals : MonoBehaviour
{
    bool isPickedUp = false;

    public Transform PlayerHold;
    public Transform InitialPos;

    public TextMeshProUGUI textToChange;

    public void Pickup()
    {
        //textToChange.text = "Picked up chemical";
        //this.transform.position = PlayerHold.position;
        //this.transform.rotation = PlayerHold.rotation;
        //this.transform.SetParent(PlayerHold, true);
        isPickedUp = true;
    }

    public void Drop()
    {
        //this.transform.rotation = InitialPos.rotation;
        //this.transform.position = InitialPos.position;
        //this.transform.SetParent(InitialPos, true);
        isPickedUp = false;
    }

    //// Start is called before the first frame update
    //void OnMouseDown()
    //{
    //    if (!isPickedUp)
    //    {
            
    //        textToChange.text = "Picked up chemical";
    //        this.transform.position = PlayerHold.position;
    //        this.transform.rotation = PlayerHold.rotation;
    //        this.transform.SetParent(PlayerHold, true);
    //        isPickedUp = true;
    //    }

    //    else
    //    {
    //        this.transform.rotation = InitialPos.rotation;
    //        this.transform.position = InitialPos.position;
    //        this.transform.SetParent(InitialPos, true);
    //        isPickedUp = false;
    //    }


        
    //}


    
    }
