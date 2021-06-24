using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    //setting up variables
    public CharacterController2D controller;
    public float moveSpeed = 40f;
    float horizontalMove = 0f;
    bool jump = false;

    //getting player input
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * moveSpeed;
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
    }

    //applying movement
    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, jump);
        jump = false;
    }

}
