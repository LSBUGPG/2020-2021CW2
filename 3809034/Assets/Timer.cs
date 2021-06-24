using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public static Timer instance;

    public Text timeCounter;

    private TimeSpan timePlaying;
    private bool timerGoing;

    private float elapsedTime;
    

    private void Awake()
    {
        instance = this;
    }


    // Start is called before the first frame update
   private void Start()
    {
        timeCounter.text = "00";
        timerGoing = false;
    }

    public void BeginTimer()
    {
        timerGoing = true;
        elapsedTime = 0f;

        StartCoroutine(UpdateTimer());

    }

    public void EndTimer()
    {
        timerGoing = false;
    }

    private IEnumerator UpdateTimer()
    {

        while (timerGoing)
        {
            elapsedTime += Time.deltaTime;
            timePlaying = TimeSpan.FromSeconds(elapsedTime);
            string timePlayingStr  = timePlaying.ToString("ss'.'ff");
            timeCounter.text = timePlayingStr;

            yield return null;
        }
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
