using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float TimerMLeft;
    public float TimerSecLeft;
    public Text TimeText;

    void Start()
    {

    }

    void Update()
    {
        if (TimerSecLeft > 0)
        {
            TimerSecLeft -= Time.deltaTime / 2;
        }
        else
        {
            TimerSecLeft = 59;
            TimerMLeft -= 1;
        }

        TimeText.text = ("Time left " + TimerMLeft.ToString("0") + " : " + TimerSecLeft.ToString("0"));

        if (TimerMLeft < 0)
        {
            SceneManager.LoadScene("Fail State");
        }

    }

}
