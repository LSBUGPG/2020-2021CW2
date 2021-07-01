using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        ScoringSystem.theScore += 1; //the number can be whatever you want it to be
        Destroy(gameObject);
    }
}
