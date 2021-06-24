using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControls : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 6f;
    public bool Grounded = true;
    private const int maxJumps = 2;
    private int currentJumps = 0;

    // Start is called before the first frame update
   private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //allows the player to move in all directions 
        float horizontal = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float vertical = Input.GetAxis("Vertical") * Time.deltaTime * speed;

        transform.Translate(horizontal, 0, vertical);

        //allows the player to jump when the spacebar is pressed, sets grounded to false and increases the count of current jumps
        if (Input.GetKeyDown("space") && (Grounded || maxJumps > currentJumps)) 
        {
            rb.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);
            Grounded = false;
            currentJumps++;
        }
    }
    //on colliding with the objects that have the tag "Floor", grounded gets set back to true to let the player jump again and sets the currentJumps back to 0
    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Floor")
        {
            Grounded = true;
            currentJumps = 0;
        }
    }
}
