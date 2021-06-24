using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public int countChange = 1;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            PickupSystem.pickupCount += countChange;
            Destroy(gameObject);
        }
    }
}
