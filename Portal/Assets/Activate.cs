using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activate : MonoBehaviour
{
    public GameObject HUB;

    public void Activation()
    {
        if (HUB.active)
            HUB.active = false;

        else
            HUB.active = true;
    }
}
