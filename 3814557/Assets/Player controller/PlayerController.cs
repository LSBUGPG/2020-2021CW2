using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    // Horizontal movement vars
    public float acceleration, deceleration;
    public float maxSpeed;

    // Vertical movement vars
    public float jumpForce;
    public LayerMask groundLayer;
    public float groundCheckDist;

    // private vars
    Rigidbody2D rb;
    bool grounded;
    float currentXVel;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        acceleration *= 10; deceleration *= 10;
    }

    // Update is called once per frame
    void Update()
    {
        // WALKING
        float h = Input.GetAxisRaw("Horizontal");
        currentXVel += acceleration * Time.deltaTime * h;
        currentXVel = Mathf.Clamp(Mathf.MoveTowards(currentXVel, 0, deceleration * Time.deltaTime), -maxSpeed, maxSpeed);

        rb.velocity = new Vector2(currentXVel, rb.velocity.y);

        // JUMPING
        // check if player is on the ground
        RaycastHit2D hit = Physics2D.Raycast(transform.position, -Vector2.up, groundCheckDist, groundLayer);
        grounded = (hit.collider != null);

        // if the player presses space AND is grounded, jump
        if(Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            rb.AddForce(Vector2.up * jumpForce);
        }
        
    }
}
