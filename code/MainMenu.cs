using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void NewGame()
    {
        // loadne dalsi level
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);


    }


    public void QuitGame()
    {
        // loadne dalsi level
        Debug.Log("quit");
        Application.Quit();

       
    }

}

