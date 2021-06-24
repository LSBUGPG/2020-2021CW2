using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCameraController : MonoBehaviour
{
    public float rotationSpeed = 75f;

    public Transform character;

    float xRotation = 0f;
        
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CamControl();        
    }

    void CamControl()
    {

        float mouseX = Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * rotationSpeed * Time.deltaTime;
        mouseY = Mathf.Clamp(mouseY, -35, 60);

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -50f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        character.Rotate(Vector3.up * mouseX);
    }
}
