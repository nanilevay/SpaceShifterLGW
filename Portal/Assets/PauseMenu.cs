using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{

    public moveControl player;
    
    public GameObject panel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void BackToMain()
    {
        Time.timeScale = 1;
        Application.LoadLevel("Menu");
    }
    public void ExitGame()
    {
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            ExitGame();
        }
            if (Input.GetKeyDown(KeyCode.P))
        {
            if (!panel.activeSelf)
            {
                Time.timeScale = 0;
                panel.active = true;
                player.lookSpeed = 0;
                Cursor.lockState = CursorLockMode.None;
            }

            else
            {
                Time.timeScale = 1;
                panel.active = false;
                player.lookSpeed = 2;
                Cursor.lockState = CursorLockMode.Locked;
            }
        }
    }
}
