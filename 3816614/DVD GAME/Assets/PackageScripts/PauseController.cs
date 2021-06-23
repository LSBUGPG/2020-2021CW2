using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class PauseController : MonoBehaviour
{

    public GameObject pauseCanvas;
    private bool isPaused;

    private void Start()
    {
        Time.timeScale = 1f;
        isPaused = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!isPaused)
            {
                pauseCanvas.SetActive(true);
                isPaused = true;
                Time.timeScale = 0f;
            }
            else
            {
                pauseCanvas.SetActive(false);
                isPaused = false;
                Time.timeScale = 1f;
            } 
        }
    }

    public void Resume()
    {
        pauseCanvas.SetActive(false);
        isPaused = false;
        Time.timeScale = 1f;
    }

    // On selecting the Main Menu button load the Main Menu scene
    public void MainMenu()
    {
        //Change SampleScene to the name of your main menu
        SceneManager.LoadScene("MainMenu");
    }

    //On selecting the quit button quit the game
    public void Quit()
    {
        Debug.Log("Quit the application");
        Application.Quit();
    }

}
