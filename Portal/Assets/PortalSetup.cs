using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalSetup : MonoBehaviour
{
    public bool occupied = false;

    public Transform PortalsToActivate;

    public int ID;

    public GameObject PortalMaterial;


    public void ObjectInside()
    {
  
            this.occupied = true;

        
    }

    public void NoObjectInside()
    {
        
            this.occupied = false;

        
    }

    void Update()
    {
        if(this.occupied)
        {
            PortalMaterial.SetActive(true);
        }

        else
        {
            PortalMaterial.SetActive(false);
        }
        //if (this.transform.childCount > 0)
        //{
        //    this.occupied = true;

        //}

        //else
        //{
        //    this.occupied = false;

        //}


    }

    //  // Update is called once per frame
    //public void UpdatePortal()
    //{
    //    if(occupied)
    //    {
    //        foreach (Transform item in PreviousItems)
    //        {
  
    //            item.gameObject.active = false;
    //            //if(index == 1)
    //            //    item.GetComponent<Renderer>().material.color = Color.red;
    //            //else
    //            //    item.GetComponent<Renderer>().material.color = Color.blue;
    //        }

    //        foreach (Transform item in ItemsInDimension)
    //        {

    //            item.gameObject.active = true;
    //            //if(index == 1)
    //            //    item.GetComponent<Renderer>().material.color = Color.red;
    //            //else
    //            //    item.GetComponent<Renderer>().material.color = Color.blue;
    //        }
    //    }

    //    else
    //    {
    //        foreach (Transform item in PreviousItems)
    //        {

    //            item.gameObject.active = true;
    //            //if(index == 1)
    //            //    item.GetComponent<Renderer>().material.color = Color.red;
    //            //else
    //            //    item.GetComponent<Renderer>().material.color = Color.blue;
    //        }

    //        foreach (Transform item in ItemsInDimension)
    //        {

    //            item.gameObject.active = false;
    //            //if(index == 1)
    //            //    item.GetComponent<Renderer>().material.color = Color.red;
    //            //else
    //            //    item.GetComponent<Renderer>().material.color = Color.blue;
    //        }
    //    }
    //}
}
