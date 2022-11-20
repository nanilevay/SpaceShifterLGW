using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotPuzzle : MonoBehaviour
{
    public bool Solved = false;
    public Transform Glasses;
    public Transform SnapPos;
    public GameObject Spinner;
    public void Success()
    {
        Solved = true;
    }

    private void Update()
    {
        if (Solved)
        {
            Glasses.rotation = SnapPos.rotation;
            Glasses.position = SnapPos.position;
            Spinner.SetActive(false);
            Glasses.SetParent(SnapPos);

        }

            
    }
}
