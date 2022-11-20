using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalManager : MonoBehaviour
{
    //public PortalSetup[] portalsToActivate;

    //public bool checker = false;

    //public GameObject PuzzleReset;

    //public GameObject PuzzleErase;

    //void UpdateObjects()
    //{
    //    foreach (GameObject item in portalsToActivate[0].ItemsToChange)
    //    {
    //        item.GetComponent<Renderer>().material.color = new Color(128f, 0f, 128f);
    //    }

    //    foreach (GameObject item in portalsToActivate[0].ItemsToShow)
    //    {
    //        item.SetActive(true);

    //        item.GetComponent<Animator>()?.SetBool("Activate", true);
    //    }

    //    foreach (GameObject item in portalsToActivate[1].ItemsToShow)
    //    {
    //        item.SetActive(true);
    //        item.GetComponent<Animator>()?.SetBool("Activate", true);
    //    }

    //    checker = false;
    //}


    //// Update is called once per frame
    //void Update()
    //{
       
    //    if(Input.GetKeyDown("r"))
    //    {
    //        Instantiate(PuzzleReset, PuzzleErase.transform.position, PuzzleErase.transform.rotation);
    //        Destroy(PuzzleErase);
                
    //    }

    //    if(portalsToActivate[0].occupied)
    //    {
    //        portalsToActivate[0].UpdatePortal();
    //    }

    //    if (portalsToActivate[1].occupied)
    //    {
    //        portalsToActivate[1].UpdatePortal();
    //    }

    //    if (portalsToActivate[0].occupied && portalsToActivate[1].occupied)
    //    {
    //        checker = true;
    //    }

    //    //if (!portalsToActivate[0].occupied)
    //    //{
    //    //    foreach (GameObject item in portalsToActivate[0].ItemsToShow)
    //    //    {
    //    //        item.SetActive(false);
    //    //    }
    //    //}

    //    //if (!portalsToActivate[1].occupied)
    //    //{
    //    //    foreach (GameObject item in portalsToActivate[1].ItemsToShow)
    //    //    {
    //    //        item.SetActive(false);
    //    //    }
    //    //}

    //    else if(!portalsToActivate[0].occupied && !portalsToActivate[1].occupied)
    //    {
    //        foreach (GameObject item in portalsToActivate[0].ItemsToChange)
    //        {
    //            item.GetComponent<Renderer>().material.color = Color.white;                
    //        }

    //        foreach (GameObject item in portalsToActivate[0].ItemsToHide)
    //        {
    //            //item.SetActive(false);
    //            item.GetComponent<Animator>()?.SetBool("Activate", false);
    //            item.SetActive(false);
    //        }

    //        foreach (GameObject item in portalsToActivate[1].ItemsToHide)
    //        {
    //            //item.SetActive(false);
    //            item.GetComponent<Animator>()?.SetBool("Activate", false);
    //            item.SetActive(false);
    //        }
    //    }

    //    if (checker)
    //        UpdateObjects();
    //}
}
