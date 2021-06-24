using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public CharacterController controller;
    public Transform camera;

    public float speed = 5f;

    public float SmoothTurn = 0.1f;
    float SmoothVelocity;

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if(direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + camera.eulerAngles.y; //atan2 to get the angle since unity goes clockwise / convert radiance 
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref SmoothVelocity, SmoothTurn ); // smothing angle so it doesnt snap in the game
            transform.rotation = Quaternion.Euler(0f, angle, 0f);
        

            Vector3 moveDirection = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward; //multiple by the vector to turn our rotation into a direction
            controller.Move(moveDirection.normalized * speed * Time.deltaTime);
        }

    }
}
