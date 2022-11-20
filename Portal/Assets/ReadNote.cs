using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ReadNote : MonoBehaviour
{

    public TextMeshProUGUI textToChange;

    public TextMeshPro textInPage;

    public GameObject panel;

    bool picked = false;

    public moveControl player;

    void Update()
    {
        //if (picked && Input.GetMouseButtonDown(0))
        //{
        //    panel.active = false;
        //    picked = false;
        //}
    }

    void OnMouseDown()
    {
        if (!panel.activeSelf)
        {
            Time.timeScale = 0;
            panel.active = true;
            textToChange.text = textInPage.text;
            player.lookSpeed = 0;
        }

        else
        {
            Time.timeScale = 1;
            panel.active = false;
            player.lookSpeed = 2;
        }
    }
}
