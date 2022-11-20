using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemChecker : MonoBehaviour
{
    public Collider Item1;
    public Collider Item2;
    public Collider Item3;
    public Collider Item4;
    public Collider Item5;

    public bool OneIn = false;
    public bool TwoIn = false;
    public bool ThreeIn = false;
    public bool FourIn = false;
    public bool FiveIn = false;

    public GameObject KeyCard;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == Item1.tag)
            OneIn = true;

        if (other.tag == Item2.tag)
            TwoIn = true;

        if (other.tag == Item3.tag)
            ThreeIn = true;

        if (other.tag == Item4.tag)
            FourIn = true;

        if (other.tag == Item5.tag)
            FiveIn = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == Item1.tag)
            OneIn = false;

        if (other.tag == Item2.tag)
            TwoIn = false;

        if (other.tag == Item3.tag)
            ThreeIn = false;

        if (other.tag == Item4.tag)
            FourIn = false;

        if (other.tag == Item5.tag)
            FiveIn = false;
    }

    private void Update()
    {
        if (OneIn && TwoIn && ThreeIn && FourIn && FiveIn)
            KeyCard.SetActive(true);
        
    }
}
