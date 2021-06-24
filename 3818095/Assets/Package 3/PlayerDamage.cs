using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    public GameObject ThePlayer;

    void OnTriggerEnter()
    {
        GetComponent<BoxCollider>().enabled = false;
       
    }

    }

