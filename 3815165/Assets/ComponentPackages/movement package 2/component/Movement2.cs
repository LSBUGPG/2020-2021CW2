using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2 : MonoBehaviour
{

    public float speed;

    public Transform justCube;

    Vector3 move;

    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        move = justCube.forward * z + justCube.right * x;
    }

    private void FixedUpdate()
    {
        rb.MovePosition((Vector3)transform.position + (move * speed * Time.deltaTime));
    }
}
