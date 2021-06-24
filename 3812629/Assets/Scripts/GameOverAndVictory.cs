using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverAndVictory : MonoBehaviour
{

    public GameObject VictoryText;
    public GameObject GameOverText;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            VictoryText.SetActive(true);
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        if (HPSystem.HPValue == 0)
        {
            GameOverText.SetActive(true);
        }
    }

}
