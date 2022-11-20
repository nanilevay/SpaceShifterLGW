using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelmetToggle : MonoBehaviour
{
    public GameObject Filter;

    public Collider Hands;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == Hands.tag)
        {
            Filter.SetActive(!Filter.activeSelf);
        }
        
    }
}
