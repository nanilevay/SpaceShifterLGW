using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadFinalScene : MonoBehaviour
{
    public PlaceBattery slotFull;

    public void Update()
    {
        if (slotFull.occupied)
        {
            Application.LoadLevel(2);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
  
        if (other.tag == "Hands" && slotFull.occupied)
        {
            Application.LoadLevel(2);
        }
    }
  
}
