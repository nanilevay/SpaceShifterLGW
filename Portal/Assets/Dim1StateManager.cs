using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dim1StateManager : MonoBehaviour
{
    public SwipeCardPuzzle swipe;

    public Animator RobotAnim;

    public GameObject[] ObjsToHide;

    public GameObject[] ObjsToShow;

    public MeshRenderer CardTurnGreen;
    private void Start()
    {
        foreach (GameObject objs in ObjsToHide)
        {
            objs.SetActive(true);
        }

        foreach (GameObject objs in ObjsToShow)
        {
            objs.SetActive(false);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(swipe.Solved)
        {
           
            foreach (GameObject objs in ObjsToHide)
            {
                objs.SetActive(false);
            }

            foreach (GameObject objs in ObjsToShow)
            {
                objs.SetActive(true);
            }

            Material Card = CardTurnGreen.material;
            Card.SetColor("_EmissionColor", Color.cyan);
        }
    }
}
