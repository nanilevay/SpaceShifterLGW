using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PastCubesManager : MonoBehaviour
{
    public GameObject Checker;
    public GameObject UV;

   
    // Update is called once per frame
    void Update()
    {
        Checker.SetActive(UV.activeSelf);
    }
}
