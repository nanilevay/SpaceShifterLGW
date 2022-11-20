using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotAnimator : MonoBehaviour
{
    public Animator anim;

    public void StartRoll()
    {
        anim.SetBool("Roll_Anim", true);
    }

    public void StartWalk()
    {
        anim.SetBool("Walk_Anim", true);
    }

    public void StartOpen()
    {
        anim.SetBool("Open_Anim", true);
    }


    public void EndRoll()
    {
        anim.SetBool("Roll_Anim", false);
    }

    public void EndWalk()
    {
        anim.SetBool("Walk_Anim", false);
    }

    public void EndOpen()
    {
        anim.SetBool("Open_Anim", false);
    }




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
