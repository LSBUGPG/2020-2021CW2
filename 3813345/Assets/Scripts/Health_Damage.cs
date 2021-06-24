using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Health_Damage : MonoBehaviour
{
    public int maxHealth;

    private int currentHealth;

    private void Start()
    {
        currentHealth = maxHealth; 
    }

    private void Update()
    {
        if (Bullet.hit)
        {
            Debug.Log("Hit");
            currentHealth -= Bullet.damage;
            Bullet.hit = false;
        }

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Destroy(gameObject);
    }

    

}
