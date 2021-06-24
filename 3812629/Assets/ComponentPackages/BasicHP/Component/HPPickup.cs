using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPPickup : MonoBehaviour
{
    public int HPIncrease = 1;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            HPSystem.HPValue += HPIncrease;
            Destroy(gameObject);
        }
    }
}
