using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondCuratorAnswer : MonoBehaviour
{
    public ConfirmPin GreenPin;
    public ConfirmPin BluePin;
    public ConfirmPin PinkPin;
    public ConfirmPin OrangePin;

    public DestroyCubeScript Cube1;
    public DestroyCubeScript Cube2;
    public DestroyCubeScript Cube3;
    public DestroyCubeScript Cube4;
    public DestroyCubeScript Cube5;
    public DestroyCubeScript Cube6;


    public GameObject Map;
    public GameObject Sol;
    public GameObject Sol2;

    public GameObject Cube;

    public Transform Container;
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GreenPin.Solved && BluePin.Solved && PinkPin.Solved && OrangePin.Solved)
        {
            Map.SetActive(false);
            Sol.SetActive(true);
        }

        if (Cube1.Solved && Cube2.Solved && Cube3.Solved && Cube4.Solved && Cube5.Solved && Cube6.Solved)
        {
            Sol2.SetActive(true);
        }

        if (Sol.activeSelf && Sol2.activeSelf)
        {
            Cube.SetActive(true);
        }
    }
}
