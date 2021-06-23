using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Force applied to rigidbody
    public float thrust;

    private Rigidbody rb;
    private bool left;
    private bool right;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        left = false;
        right = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            left = true;
        }
        else
        {
            left = false;
        }
        if (Input.GetKey(KeyCode.D))
        {
            right = true;
        }
        else
        {
            right = false;
        }
       
    }

    private void FixedUpdate()
    {
        //Apply force to the left of the rigidbody
        if (left)
        {
            rb.AddForce(Vector3.left * thrust * Time.fixedDeltaTime);
        }
        //Apply force to the right of the rigidbody
        if (right)
        {
            rb.AddForce(Vector3.right * thrust * Time.fixedDeltaTime);
        }
    }
}
