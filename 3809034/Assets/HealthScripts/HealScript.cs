﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealScript : MonoBehaviour
{
    public HealthScript health;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {
            health.Heal(1);
        }

    }
}
