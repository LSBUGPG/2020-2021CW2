using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Debug.Log("PLAYGAME");
    }
    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("QUITGAME");
    }

    public void ReturnToMain()
    {
        SceneManager.LoadScene(0);
    }
}
