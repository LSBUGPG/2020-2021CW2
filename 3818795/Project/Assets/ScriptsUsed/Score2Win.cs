using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Score2Win : MonoBehaviour
{
    public bool Endgame;
    public int Score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Score = AllUIInfo.Score4UI;
        if(Score >= 100)
        {
            Endgame = true;
        }

        if(Endgame == true)
        {
            SceneManager.LoadScene("EndGame");
        }
    }
}
