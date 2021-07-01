using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deposit : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (ScoringSystem.theScore == 5)
        {
            ScoringSystem.theScore -= 5; //number can be whatever you want it to be
        }
        
    }

}
