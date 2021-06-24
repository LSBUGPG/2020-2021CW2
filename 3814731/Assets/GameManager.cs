using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    //bool gameHasEnded = false;
    public bool GamePlaying { get; private set; }

    public float restartDelay = 3f;
    public GameObject endGameUI;
    public TMP_Text timeLeftText;
    public TMP_Text progressMadeText;
    public TMP_Text hpLeftText;

    public PlayerMovement playerMov;
    public Timer timer;

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        GamePlaying = true;
    }
    void Update()
    {
        if (GamePlaying == true)
        {
            Time.timeScale = 1f;
        }
        else if (GamePlaying == false)
        {
            Time.timeScale = 0f;
        }
    }

    public void GameFinished()
    {
        GamePlaying = false;
        timeLeftText.SetText(timer.timeRemaining.ToString());
        progressMadeText.SetText(playerMov.progressCurrentValue.ToString());
        hpLeftText.SetText(playerMov.currentValue.ToString());
    }

    public void EndGame()
    {
        GamePlaying = false;
        //Debug.Log("GAME OVER");
        Restart();
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        if (endGameUI.activeSelf)
        {
            endGameUI.SetActive(false);
        }
    }


}
