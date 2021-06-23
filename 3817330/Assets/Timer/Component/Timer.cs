using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    Image timeBar;
    public float maxTime = 5f;
    float timeLeft;
    public static bool gameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        timeBar = GetComponent<Image>();
        timeLeft = maxTime;
    }

    // Update is called once per frame
    public void Update()
    {
        if (LightTimerScript.depleteTimer == true)
        {
            if (timeLeft > 0)
            {
                timeLeft -= Time.deltaTime;
                timeBar.fillAmount = timeLeft / maxTime;

                if (timeLeft <= 0)
                {
                    gameOver = true;
                    Time.timeScale = 0;
                }
            }
        }
    }
}
