using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCubeScript : MonoBehaviour
{
    public Collider Hand;
    public Collider Self;

    public bool Solved = false;

    private void OnTriggerEnter(Collider other)
    {
        if (Hand.tag == Self.tag)
        {
            this.GetComponent<MeshRenderer>().enabled = false;
            Solved = true;
        }
    }
}
