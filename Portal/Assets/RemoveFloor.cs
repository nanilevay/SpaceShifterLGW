using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveFloor : MonoBehaviour
{
    public GameObject[] FloorItems;

    // Start is called before the first frame update
    void Start()
    {
        foreach(GameObject objecto in FloorItems)
            objecto.active = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
