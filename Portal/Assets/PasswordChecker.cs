using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PasswordChecker : MonoBehaviour
{
    public GameObject Cube;
    public string correctInput = " ";
    public string userInput = " ";

    public string SuccessText = "Open!";

    public PasswordKeys[] keys;

    public TextMeshPro textToChange;

    public bool notSolved = true;

    // Update is called once per frame
    void Update()
    {
        foreach(PasswordKeys key in keys)
        {
            if (notSolved)
            {
                if (userInput.Length >= correctInput.Length)
                    if (userInput == correctInput)
                        notSolved = false;
                    else
                        userInput = "";

                if (key.wasPressed)
                {
                    userInput += key.value;

                    key.wasPressed = false;
                }


            }

            else
            {
                userInput = SuccessText;
                Cube.SetActive(true);
                //this.GetComponent<PuzzleComponents>().IsActive = true;
            }

            textToChange.text = userInput;
        }
    }
}
