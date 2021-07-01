using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AllUIInfo : MonoBehaviour
{
    public static int Score4UI;
    public Text ScoreText;
  

    // Update is called fdce per frame
    void Update()
    {
        Score4UI = RandomMovements.Score;
        ScoreText.text = ("Score " + Score4UI);
    }
}
