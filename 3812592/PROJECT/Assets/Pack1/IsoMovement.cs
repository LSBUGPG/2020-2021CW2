using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsoMovement : MonoBehaviour
{
    public float speed;


    void Start()
    {

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.rotation = Quaternion.Euler(0, 90, 0);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.rotation = Quaternion.Euler(0, -90, 0);
        }
}

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, +speed, Space.World);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -speed, Space.World);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(+speed, 0, 0, Space.World);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed, 0, 0, Space.World);
        }

    }
}
