using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damagePlayer : MonoBehaviour
{
    public int playerHealth=100;
    int damage=10;

    private void Start()
    {
        print(playerHealth);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Projectile")
        {
            playerHealth -= damage;
            print("Taken damage" + playerHealth);
        }
        if (playerHealth <= 0)
        {
            Die();
            Destroy(this.gameObject);
        }
    }
    private void Die()
    {
        gameObject.SetActive(false);
    }
}
