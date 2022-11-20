using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackToLab : MonoBehaviour
{
    public Transform Player;
    public Transform Destination;

    public void MoveBack()
    {
        Player.position = new Vector3(Destination.GetComponent<Transform>().position.x, Player.position.y, Destination.GetComponent<Transform>().position.z);
    }
}
