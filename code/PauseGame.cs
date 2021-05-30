using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseGame : MonoBehaviour
{
    public GameObject PauseMenuUI;
    public static bool PausedGame = false;
    int Cameras;
 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0f;
            if (PausedGame)
            {
                ResumeGame();
               
            }
            else
            {
               PausingGame();            

            }
        }
    }
    
      public void PausingGame()
        {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;     
        PausedGame = true;


      //  GameObject camerabox = GameObject.Find("CamerBox");
    //    CameraMovement CameraMovement = camerabox.GetComponent<CameraMovement>();
     //   CameraMovement.CameraSpeed = 0f;


    }

    
    public void ResumeGame() {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        PausedGame = false;

    

    }

    public void LoadMenu()
    {

    }
    public void QuitInGame()
    {
     SceneManager.LoadScene(0);

    }
        
    
}
