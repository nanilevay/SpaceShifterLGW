using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateRocks : MonoBehaviour
{
    
    Animator m_Animator;
    


    void Start()
    {
        
        m_Animator = gameObject.GetComponent<Animator>();
   
    }

    public void Rotate()
    {
         m_Animator.SetBool("Rotate", true);
    }


    public void UndoRotate()
    {
        m_Animator.SetBool("Rotate", false);
    }

}
