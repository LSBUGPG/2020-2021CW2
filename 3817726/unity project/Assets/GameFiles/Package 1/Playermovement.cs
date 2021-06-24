using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    public float moveSpeed;
    public bool facingRight;

    public float jumpHeight;
    private bool isGrounded;

    private void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        transform.position += move * moveSpeed * Time.deltaTime;

        if(Input.GetKeyDown (KeyCode.Space) && isGrounded)
        {
            GetComponent<Rigidbody>() .AddForce(new Vector3(0, jumpHeight), ForceMode.Force);
        }
    }

    void OnTriggerEnter()

    {
        isGrounded = true;
    }
    void OnTriggerStay()
    {
        isGrounded = true;
    }
    void OnTriggerExit()
    {
        isGrounded = false;
    }

    //this script is used for a simple left and right player movement script and a jump script, this then allows me to be able to change the power of the jumping and walking in the inspector in unity.

}
