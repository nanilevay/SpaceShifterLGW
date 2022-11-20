using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLiquidColour : MonoBehaviour
{
    public Material flaskContents;

    void Start()
    {
        flaskContents.SetColor("_Color1", Color.green);
    }

    public void ChangeColour()
    {
        if(flaskContents.GetColor("_Color1") == Color.green 
            || flaskContents.GetColor("_Color1") == Color.blue)
            flaskContents.SetColor("_Color1", Color.red);

        else
            flaskContents.SetColor("_Color1", Color.blue);
    }
}
