using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _teleporter : MonoBehaviour
{
    public Transform PlayerPos;

    public TestObject GazeChecker;

    public GameObject PortalEffect;

    public GameObject HUD;

    public GameObject Chair;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GazeChecker.isGazingUpon)
        {
            if(HUD.activeSelf)
                PortalEffect.SetActive(true);
        }

        if (!HUD.activeSelf)
        {
            PortalEffect.SetActive(false);
        }
    }

    public void Teleport()
    {
        if (GazeChecker.isGazingUpon && HUD.activeSelf)
        {
            PortalEffect.SetActive(false);
            PlayerPos.position = new Vector3(Chair.GetComponent<Transform>().position.x, PlayerPos.position.y,Chair.GetComponent<Transform>().position.z);
            
            Chair.SetActive(false);      
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            PortalEffect.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            Chair.SetActive(true);
        }
    }
}
