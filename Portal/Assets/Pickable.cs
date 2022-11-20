using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Pickable : MonoBehaviour
{
    public bool isPickedUp = false;
    public bool notInPortal = true;
    public bool inPortalReach = false;

    public Transform PlayerHold;
    public Transform PortalHold;
    public Transform InitialPos;

    public int ID;

    public TextMeshProUGUI textToChange;

    //void OnTriggerEnter(Collider other)
    //{
    //    if (other.tag == "deadZone")
    //    {
    //        this.GetComponent<Rigidbody>().isKinematic = false;
    //        Debug.Log("dropped cube");
    //        textToChange.text = "Dropped cube";
    //        this.transform.rotation = InitialPos.rotation;
    //        this.transform.position = InitialPos.position;
    //        this.transform.SetParent(InitialPos);
    //        isPickedUp = false;

            
    //    }
    //}

    //void OnTriggerStay(Collider other)
    //{
    //    if (other.tag == "portal" && !other.GetComponent<PortalSetup>().occupied && other.GetComponent<PortalSetup>().ID == this.ID )
    //    {
    //        inPortalReach = true;
    //        PortalHold = other.GetComponent<Transform>();
    //    }

       
    //}

    //void OnTriggerExit(Collider other)
    //{
    //    if (other.tag == "portal")
    //    {
    //        inPortalReach = false;
    //        PortalHold = null;
    //    }
    //}


    // Start is called before the first frame update
    public void OnPickup()
    {
        isPickedUp = true;
        notInPortal = true;
    }

    public void OnDrop()
    {
        isPickedUp = false;
        notInPortal = true;
    }

    public void InPortal()
    {
        isPickedUp = false;
        isPickedUp = true;
        notInPortal = false;
    }


    //if (!isPickedUp)
    //{
    //    //this.GetComponent<Rigidbody>().isKinematic = true;
    //    //Debug.Log("picked up cube");
    //    //textToChange.text = "Picked up cube";
    //    //this.transform.position = PlayerHold.position;
    //    //this.transform.rotation = PlayerHold.rotation;
    //    //this.transform.SetParent(PlayerHold, true);

    //}


    //{
    //    if (inPortalReach)
    //    {
    //else if (isPickedUp && notInPortal)
    //        //Debug.Log("placed cube in portal");
    //        //textToChange.text = "Placed in portal";
    //        //this.transform.position = PortalHold.position;
    //        //this.transform.rotation = PortalHold.rotation;
    //        //this.transform.SetParent(PortalHold, true);
    //        isPickedUp = false;
    //    }

    //    else
    //    {
    //        //this.GetComponent<Rigidbody>().isKinematic = false;
    //        //Debug.Log("dropped cube");
    //        //textToChange.text = "Dropped cube";
    //        //this.transform.SetParent(null);
    //        isPickedUp = false;
    //    }
//}

        //else if(isPickedUp && notInPortal)
        //{
        //    Debug.Log("placed cube in portal");
        //    isPickedUp = false;
        //    notInPortal = false;
        //}

        //else if (isPickedUp && !notInPortal)
        //{
        //    Debug.Log("placed cube in portal");
        //    isPickedUp = false;
        //    notInPortal = false;
        //}
    //}

    // Update is called once per frame
    void Update()
    {
        //if()
    }
}
