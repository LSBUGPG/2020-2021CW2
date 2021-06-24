using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverScreen;

    // Start is called before the first frame update
    void Start()
    {
        gameOverScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collision)
    {
        if(collision.tag == "Out of Bounds")
        {
            Pause();
            gameOverScreen.SetActive(true);
        }
    }

    void Resume()
    {
        Time.timeScale = 1;
    }
    void Pause()
    {
        Time.timeScale = 0;
    }
}
