using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animatable : MonoBehaviour
{
    public string animatorTrigger;

    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void StartAnimation()
    {
        animator.SetTrigger(animatorTrigger);
    }
}
