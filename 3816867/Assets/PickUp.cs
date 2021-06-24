using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUp : MonoBehaviour
{
    int coinCount = 0;
    public Text coinsCollectedText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("GameController"))
        {
            coinCount += 1;
            coinsCollectedText.text = "Coins collected: " + coinCount;
            Destroy(other.gameObject);
        }
    }
}
