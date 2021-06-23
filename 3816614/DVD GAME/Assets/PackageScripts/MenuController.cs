using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuController : MonoBehaviour
{

   // On selecting the play button load the first game scene
   public void Play()
    {
        //Change Scene1 to the name of your first game scene
        SceneManager.LoadScene("Scene1");
    }

    //On selecting the quit button quit the game
    public void Quit()
    {
        Debug.Log("Quit the application");
        Application.Quit();
    }

    public void Settings()
    {
        //Change Scene1 to the name of your settigns scene if you have one
        SceneManager.LoadScene("Settings");
    }
}
