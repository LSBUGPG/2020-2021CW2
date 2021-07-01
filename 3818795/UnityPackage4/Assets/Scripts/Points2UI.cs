using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points2UI : MonoBehaviour
{
    public int Score4UI;
    public Text ScoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Score4UI = Points.Score + PointOutOfBounds.Score;
        ScoreText.text = ("Points " + Score4UI);
    }
}
