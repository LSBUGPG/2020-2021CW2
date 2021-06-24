﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassBy : MonoBehaviour
{

    public Animator animator;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            animator.SetTrigger("Activate");
        }
    }
}
