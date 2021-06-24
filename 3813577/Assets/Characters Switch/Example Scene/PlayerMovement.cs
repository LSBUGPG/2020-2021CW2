using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    Vector3 velocity;
    public Transform GroundCheck;
    public LayerMask groundMask;
    bool isGrounded;
    Transform Player;

    float speed;
    public float JumpHeight;
    public float CrouchHeight;
    public float NormalHeight;
    public float gravity = -9.81f;
    public float GroundDistance = 0.4f;
    public float WalkSpeed;
    public float RunSpeed;
    public bool MultiJump;
    int JumpCount = 0;
    public int AllowedJumps;

    // Start is called before the first frame update
    void Start()
    {
        Player = GetComponent<Transform>();
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftShift))
		{
            speed = WalkSpeed;
		}
		else
		{
            speed = RunSpeed;
		}
        isGrounded = Physics.CheckSphere(GroundCheck.position, GroundDistance, groundMask);

        if (isGrounded)
		{
            JumpCount = 0;
		}

        if(isGrounded && velocity.y < 0)
		{
            velocity.y = -2f;
		}
        float X = Input.GetAxis("Horizontal");
        float Z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * X + transform.forward * Z;

        controller.Move(move * speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

        if(Input.GetButtonDown("Jump") && isGrounded && MultiJump == false)
		{
            velocity.y = Mathf.Sqrt(JumpHeight * -2f * gravity);
		}

        if (Input.GetButtonDown("Jump") && MultiJump == true && JumpCount < AllowedJumps)
        {
            velocity.y = Mathf.Sqrt(JumpHeight * -2f * gravity);
            JumpCount += 1; 
        }

        if (Input.GetKeyDown(KeyCode.LeftControl))
		{
            Player.transform.localScale = new Vector3(X, CrouchHeight, Z);
		}
        else if (Input.GetKeyUp(KeyCode.LeftControl))
		{
            Player.transform.localScale = new Vector3(X, NormalHeight, Z);
        }
    }
}
