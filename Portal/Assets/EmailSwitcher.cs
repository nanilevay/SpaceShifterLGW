using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmailSwitcher : MonoBehaviour
{
    public GameObject[] emails;
    public GameObject background;
   
    public int index = -1;

    private void Update()
    {
        if(index < -1 || index > 3)
        {
            index = 0;
        }
    }


    public void Forward()
    {
        index += 1;
         emails[0].active = false;
         emails[index - 1].active = false;
         emails[index].active = true;
        
    }


    public void Backwards()
    {
        index -= 1;
        
        emails[index+1].active = false;
        emails[index].active = true;
        
    }
}
