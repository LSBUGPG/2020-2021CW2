using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    public int Score;
    public Text ScoreUI1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Score = ButtonClick.Clicks;
        ScoreUI1.text = "Score = " + Score;
    }
}

