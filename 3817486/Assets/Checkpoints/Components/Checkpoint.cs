using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public Transform checkpoint;
    public GameObject Plyr;

  

    void OnTriggerEnter(Collider collision)
    {
        Debug.Log("Collision Detected");

        if(collision.gameObject.tag == "Player")
        {
            Plyr.transform.position = checkpoint.position;
            Plyr.transform.rotation = checkpoint.rotation;

        }
    }
}
