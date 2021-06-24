using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script to be put on the "player"

public class CollectCoin : MonoBehaviour
{
    public GameObject Coin;

  void OnTriggerEnter(Collider other)
  {
        if(other.gameObject.CompareTag("Bullet"))
        {
            Destroy(Coin);
            //Debug.Log("cyuft");
            other.GetComponent<CoinCount>().points++;
        }
  }

    
}
