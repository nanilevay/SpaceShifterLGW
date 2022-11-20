using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WatchRemover : MonoBehaviour
{
    public Transform WatchPlacement;
    public GameObject WatchHolder;

    private void Update()
    {
        if(WatchPlacement.childCount > 0)
        {
            WatchHolder.SetActive(false);
        }
    }
}
