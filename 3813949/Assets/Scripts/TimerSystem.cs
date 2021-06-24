using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class TimerSystem : MonoBehaviour
{
    public GameObject textDisplay;
    public int secondsLeft = 10;
    public UnityEvent TimeUp;

    void Start()
    {
        textDisplay.GetComponent<Text>().text = secondsLeft / 60 + " : " + (secondsLeft % 60).ToString("D02");
        StartCoroutine(countdown());
    }

   
    
    IEnumerator countdown()
    {
        while(true)
        {
           
            yield return new WaitForSeconds(1);
            secondsLeft -= 1;
            textDisplay.GetComponent<Text>().text = secondsLeft / 60 + " : " + (secondsLeft % 60).ToString("D02");
            if (secondsLeft == 0)
            {
                TimeUp.Invoke();
                break;
            }
            
        }
        
    }
}
