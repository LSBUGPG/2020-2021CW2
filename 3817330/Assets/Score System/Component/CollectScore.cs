using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectScore : MonoBehaviour
{
    public static bool collected = false;

    private void OnTriggerEnter(Collider other)
    {
        collected = true;
        ScoreSystem.theScore += 10;
        Destroy(gameObject);
    }
}
