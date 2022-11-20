using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeCardPuzzle : MonoBehaviour
{
    public bool Solved = false;
    public Collider SwipeCard;

    public void OnTriggerStay(Collider other)
    {
        if(other.tag == SwipeCard.tag)
        {
            Solved = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.tag == SwipeCard.tag)
        {
            Solved = false;
        }
    }
}
