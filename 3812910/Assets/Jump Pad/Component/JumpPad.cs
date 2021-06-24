using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{
    public GameObject Player;
    [Range(100, 1000)]
    public float bouncehight;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject == Player)
        {
            GameObject bouncer = collision.gameObject;
            Rigidbody rb = bouncer.GetComponent<Rigidbody>();
            rb.AddForce(Vector3.up * bouncehight);
        }
    }

    /*private void OnCollisionEnter(Collision collision)
    {
        GameObject bouncer = collision.gameObject;
        Rigidbody rb = bouncer.GetComponent<Rigidbody>();
        rb.AddForce(Vector3.up * bouncehight);
    }*/
}