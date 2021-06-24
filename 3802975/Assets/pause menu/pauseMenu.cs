using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour
{
    public static bool GamePaused = false;
    public GameObject PausemenuUI;

    // Start is called before the first frame update
    void Start()
    {

        PausemenuUI.SetActive(false);
        GamePaused = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))

            if (GamePaused == false)
            {
                Pause();
            }
            else
            {
                Resume();
            }
    }

   public void Resume()

    {
        PausemenuUI.gameObject.SetActive(false);
        Time.timeScale = 1f;
        GamePaused = false;
    }

   public void Pause()

    {
        PausemenuUI.gameObject.SetActive(true);
        Time.timeScale = 0f;
        GamePaused = true;
    }

   public void Exit()

    {
        SceneManager.LoadScene("main menu");
    }
}
