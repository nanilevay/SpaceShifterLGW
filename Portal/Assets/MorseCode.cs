using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// old logic lol
/// </summary>
public class MorseCode : MonoBehaviour
{
    public GameObject Lighter;

    public string Sequence;

    bool wakeUp = true;

    bool Awake = false;

    public GameObject Puzzle;

    IEnumerator MorseDisplay()
    {
            foreach (char character in Sequence)
            {
                if (character == '.')
                {
                    Lighter.GetComponent<Renderer>().material.color = Color.blue;
                    yield return new WaitForSeconds(0.5f);
                    Lighter.GetComponent<Renderer>().material.color = Color.black;
                    yield return new WaitForSeconds(0.5f);
                }

                if (character == '-')
                {
                    Lighter.GetComponent<Renderer>().material.color = Color.blue;
                    yield return new WaitForSeconds(1.5f);
                    Lighter.GetComponent<Renderer>().material.color = Color.black;
                    yield return new WaitForSeconds(0.5f);
                }

                if (character == ' ')
                {
                    Lighter.GetComponent<Renderer>().material.color = Color.black;
                    yield return new WaitForSeconds(1.5f);
                }


            }

            Lighter.GetComponent<Renderer>().material.color = Color.black;
            yield return new WaitForSeconds(2);

        wakeUp = true;
      
    }

    void Update()
    {
        if (Puzzle.activeSelf)
            Awake = true;

        else
            Awake = false;

        if (Awake && wakeUp)
        {
            wakeUp = false;
            StartCoroutine(MorseDisplay());
        }
            
    }
  
}