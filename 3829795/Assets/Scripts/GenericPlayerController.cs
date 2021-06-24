using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericPlayerController : MonoBehaviour
{
    public float speed = 10f;
    
    private Rigidbody rb;

    public float jumpHeight = 4f;

    public bool isGrounded = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpHeight, ForceMode.Impulse);
            isGrounded = false;
        }
    }

    void FixedUpdate()
    {
        float xMov = Input.GetAxisRaw("Horizontal");
        float zMov = Input.GetAxisRaw("Vertical");

        rb.velocity = new Vector3(xMov*speed, rb.velocity.y, zMov*speed);  
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Ground")
        {
            isGrounded = true;
        }
    }
}