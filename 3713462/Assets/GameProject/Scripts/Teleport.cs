using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform destination;

    //transforms the position of the player to the set destination by using on trigger
     void OnTriggerEnter(Collider col)
    {
        col.transform.position = destination.transform.position;
    }
}
