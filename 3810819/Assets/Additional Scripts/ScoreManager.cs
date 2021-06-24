using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour
{
    // Most of this script makes use of the score counter video
    // https://www.youtube.com/watch?v=QbqnDbexrCw

    public List<GameObject> targets;

    [SerializeField] GameObject winTrigger;

    int maxTargets;

    Text targetText;
    
    static int currentScore = 0;

    static int points = 1;
           
    void Awake()
    {
               
    }

    // Start is called before the first frame update
    void Start()
    {
        winTrigger.SetActive(false);
        
        targetText = GetComponent<Text>();

        maxTargets = targets.Count;
        
    }

    void Update()
    {
        targetText.text = "Targets Hit: " + currentScore + " of " + maxTargets;

        if(currentScore == maxTargets)
        {
            winTrigger.SetActive(true);
        }
    }

    static public void AddPoints()
    {
        currentScore += points;
    }
}
