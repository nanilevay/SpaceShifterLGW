using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadMenu : MonoBehaviour
{

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            LoadScene();
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            LoadScene();
        }
    }
    public void LoadScene()
    {
        Application.LoadLevel(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
