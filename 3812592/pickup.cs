using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour
{
    public Transform pickupspot;
    public GameObject pickupspotobj;
    public Rigidbody rb;
    public float power;
    public bool pickupallowed;

    public void Start()
    {
        rb = GetComponent<Rigidbody>();
        pickupallowed = true;
    }

    public void OnMouseDown()
    {
        if (pickupallowed == true)
        {
            rb.velocity = Vector3.zero;
            rb.useGravity = false;
            transform.position = pickupspot.position;
            transform.parent = pickupspotobj.transform;
            transform.rotation = pickupspot.rotation;
            rb.freezeRotation = true;
            pickupallowed = false;
        }
    }

    public void OnMouseUp()
    {
        if (pickupallowed == false)
        {
            transform.parent = null;
            rb.useGravity = true;
            rb.freezeRotation = false;
            rb.AddForce(transform.forward * power);
            pickupallowed = true;
        }
    }
}
