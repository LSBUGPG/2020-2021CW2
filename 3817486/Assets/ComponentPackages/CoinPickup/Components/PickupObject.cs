using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObject : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        if (gameObject.tag == "Coin")
        {
            Destroy(gameObject);
        }
        }

}
