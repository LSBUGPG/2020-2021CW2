using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerRestartLink : MonoBehaviour
{
    public GameObject restartScene;

    // Start is called before the first frame update
    void Start()
    {
        restartScene.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Timer.gameOver == true)
        {
            restartScene.SetActive(true);
        }
    }
}
