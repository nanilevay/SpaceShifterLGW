using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Security.Cryptography;
using UnityEngine;

public class portalTeleporter : MonoBehaviour
{
   //public CharacterController player;
    public GameObject giver;
    public GameObject receiver;

    private bool playerIsIn = false;

    // Update is called once per frame
    void Update()
    {
        if(playerIsIn)
        {      
            //Vector3 portalToPlayer = player.transform.position - transform.position;
            //float dotProduct = Vector3.Dot(transform.up, portalToPlayer);

            //if(dotProduct < 0f)
            //{
                //UnityEngine.Debug.Log("oof");
                //float rotationDiff = -Quaternion.Angle(transform.rotation, receiver.rotation);
                //rotationDiff += 180;

                //player.transform.Rotate(Vector3.up, rotationDiff);

                //Vector3 positionOffset = Quaternion.Euler(0f, rotationDiff, 0f) * portalToPlayer;
                //player.enabled = false;
                //receiver.GetComponent<portalTeleporter>().enabled = false;
                //player.transform.position = receiver.position + positionOffset;
                //player.enabled = true;
                UnityEngine.Debug.Log("hiiiiiiiii");
                giver.SetActive(false); 

                receiver.SetActive(true);
                //StartCoroutine(Cooldown());

                playerIsIn = false;
            //}
        }
        
    }

    void OnTriggerEnter (Collider other)
    {
        if(other.tag == "Player")
        {
           
            playerIsIn = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            playerIsIn = false;
        }
    }

    public IEnumerator Cooldown()
    {
        yield return new WaitForSeconds(3);
        receiver.GetComponent<portalTeleporter>().enabled = true;
        yield break;
    }
}
