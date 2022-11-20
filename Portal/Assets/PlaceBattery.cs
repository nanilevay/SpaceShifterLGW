using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceBattery : MonoBehaviour
{
    public bool occupied = false;
    public bool fakeoccupied = false;
    public GameObject GivenTag;

    public AudioSource audioSource;
  
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "UnchargedBattery")
        {
            this.fakeoccupied = true;
            audioSource.Play();
        }


        if (other.tag == GivenTag.tag)
        {
           
            this.occupied = true;
            Debug.Log(GivenTag.tag);
        }



    }

    private void OnTriggerExit(Collider other)
    {
       
        if (other.tag == GivenTag.tag)
        {
           

            this.occupied = false;
        }
    }

    //public void ObjectInside()
    //{
    //    this.occupied = true;
    //}

    public void NoObjectInside()
    {
        this.occupied = false;
    }


}
