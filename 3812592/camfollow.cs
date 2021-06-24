using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camfollow : MonoBehaviour
{
    public Transform target;
    private Vector3 offset;
    private Vector3 campos;

    void Start()
    {
        offset = transform.position - target.position;
    }

    void FixedUpdate()
    {
        campos = target.position + offset;
        transform.position = campos;
    }
}
