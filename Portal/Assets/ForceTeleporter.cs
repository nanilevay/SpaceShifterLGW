using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceTeleporter : MonoBehaviour
{
    public WalkScript walker;
    public LabChecker InLab;

    public Transform Player;

    public bool moving = false;

    void Update()
    {

        if (!InLab.inLab)
        {
            walker.enabled = false;
            moving = false;
        }

        if (InLab.inLab && moving)
        {
            walker.enabled = true;
            walker.Mover(Player);
               
        }
        
    }

    public void StartMotion()
    {
        if (InLab.inLab)
            moving = true;

        else
            moving = false;
    }

    public void StopMotion()
    {
        moving = false;
    }
}
