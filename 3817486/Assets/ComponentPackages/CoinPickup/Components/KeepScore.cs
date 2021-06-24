using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeepScore : MonoBehaviour
{
    public GameObject scoreText;
    public static int coinsCollected;

     void OnTriggerEnter(Collider other)
    {
        coinsCollected += 1;
        scoreText.GetComponent<Text>().text = "Coins: " + coinsCollected;
        GetComponent<ParticleDeath>();
        Destroy(gameObject);
        
    }
}
