using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WatchSnap : MonoBehaviour
{
    public GameObject Disable;
    public Collider Hand;
    public Transform WatchPos;
    public Transform SnapPos;
    public GameObject UI;

    private void OnTriggerEnter(Collider other)
    {
        if (Hand.tag == other.tag)
        {
            WatchPos.rotation = SnapPos.rotation;
            WatchPos.position = SnapPos.position;
            Disable.SetActive(false);
            WatchPos.SetParent(SnapPos);
            UI.SetActive(true);
        }
    }
}
