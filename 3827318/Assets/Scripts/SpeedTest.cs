using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedTest : MonoBehaviour
{
    // public Text lapText;
    public float currentTime = 0;
    public bool active = false;
    void Start()
    {

    }
    void Update()
    {
        if (active)
        {
            currentTime += Time.deltaTime;
            /*if (Input.GetKeyDown(KeyCode.Return))
            {
                lapText.text = ("Sec:" + Lap())
            currentTime = 0;
            }*/

        }



    }
    public float Lap()   // you can call this function from other scripts as well
    {
        return currentTime;


    }
}
