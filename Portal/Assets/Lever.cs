using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    public bool up;
    public Animator anim;
    public GameObject item;

    public bool Cond = false;

    public int UpOrDown;

    void Start()
    {
        if (UpOrDown == 0)
            Cond = true;
    }

    void OnMouseDown()
    {
        if (!up)
        {
            up = true;
            anim.SetBool("MoveUp", true);
            item.GetComponent<Renderer>().material.color = Color.green;
            if(UpOrDown == 1)
                Cond = true;
            if (UpOrDown == 0)
                Cond = false;
        }

        else
        {
            up = false;
            anim.SetBool("MoveUp", false);
            item.GetComponent<Renderer>().material.color = Color.red;
            if (UpOrDown == 0)
                Cond = true;
            if (UpOrDown == 1)
                Cond = false;
        }
    }
}
