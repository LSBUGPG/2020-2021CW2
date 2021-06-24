using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPDamage : MonoBehaviour
{
    public int DamageAmount = 1;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            HPSystem.HPValue -= DamageAmount;
        }
    }
}
