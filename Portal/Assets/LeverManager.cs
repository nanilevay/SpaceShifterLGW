using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// old logic lol
/// </summary>
public class LeverManager : MonoBehaviour
{
    public string solution = "udu";

    public string player = null;

    bool checking = false;

    public Lever[] levers;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void UpdateCombo()
    {
        foreach (Lever lever in levers)
        {
            if (lever.up)
                player += "u";
            checking = false;
        }

        if (solution == player)
        {
            Debug.Log("Victory");
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        foreach (Lever lever in levers)
        {
            if (lever.up)
                checking = true;
        }

        if (checking)
            UpdateCombo();
    }
}
