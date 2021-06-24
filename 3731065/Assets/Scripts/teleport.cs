using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{

    public Transform Destination;
    public GameObject Player;

     void OnTriggerEnter(Collider other)
     {
        if (other.gameObject.CompareTag("Player"))
        {
         other.transform.position = Destination.transform.position;
        }

        //Player.transform.position = Destination.transform.position; (alternate version of teleporting)
     }
        
}
