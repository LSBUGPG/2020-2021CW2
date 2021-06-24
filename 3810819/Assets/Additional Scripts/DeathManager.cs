using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathManager : MonoBehaviour
{
    [SerializeField] GameObject deathScreen;

    [SerializeField] GameObject minimap, scoreCanvas, crosshair;


    void Start()
    {
        deathScreen.SetActive(false);
        minimap.SetActive(true);
        scoreCanvas.SetActive(true);
        crosshair.SetActive(true);
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {
            deathScreen.SetActive(true);

            minimap.SetActive(false);
            scoreCanvas.SetActive(false);
            crosshair.SetActive(false);



            Pause();
        }
    }

    void Pause()
    {
        Time.timeScale = 0;
    }
}
