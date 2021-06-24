using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeAttack : MonoBehaviour
{
    //Variables;
    Animator anim;


    private void Start()
    {
        anim = GetComponent<Animator>();
    }


    private void Update()
    {
        if (Input.GetButtonDown("E"))
            anim.SetBool("attacking", true);
        else if(Input.GetButtonUp("E"))
            anim.SetBool("attacking", false);
    }
}
