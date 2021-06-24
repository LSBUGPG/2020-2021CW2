using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public CharacterController characterController;
    public Transform cameraTransform;

    public float speed;
    public float gravity;
    public float jumpForce;

    private float horizontalMovement;
    private float verticalMovement;

    private Vector3 direction;

    private float lookAngle;
    private Vector3 movement;

    private Vector3 fallVelocity;

    private bool isGrounded;

    private void Start()
    {
        gravity = -gravity;
    }

    private void Update()
    {
        horizontalMovement = Input.GetAxis("Horizontal");
        verticalMovement = Input.GetAxis("Vertical");

        direction = new Vector3(horizontalMovement, 0, verticalMovement).normalized;

        if (direction.magnitude > 0.1)
        {
            lookAngle = Mathf.Atan2(horizontalMovement, verticalMovement) * Mathf.Rad2Deg + cameraTransform.eulerAngles.y;
            transform.rotation = Quaternion.Euler(0, lookAngle, 0);

            movement = Quaternion.Euler(0, lookAngle, 0) * Vector3.forward;

            characterController.Move(movement.normalized * speed * Time.deltaTime);
        }

        isGrounded = characterController.isGrounded;

        if (isGrounded && fallVelocity.y <= 0)
        {
            fallVelocity.y = gravity;
        }

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            fallVelocity.y = Mathf.Sqrt(jumpForce * -2 * gravity);
        }

        fallVelocity.y += gravity * Time.deltaTime;

        characterController.Move(fallVelocity * Time.deltaTime);
    }
}
