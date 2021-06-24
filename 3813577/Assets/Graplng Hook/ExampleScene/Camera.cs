using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Camera : MonoBehaviour
{
    public float MouseSensitivity;
    public Transform PlayerBody;
    public Transform PlayerCamera;

    float cameraPitch = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
       Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {

            Vector2 mouseDelta = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
            PlayerBody.Rotate(Vector3.up * mouseDelta.x * MouseSensitivity);
            cameraPitch -= mouseDelta.y * MouseSensitivity;
            cameraPitch = Mathf.Clamp(cameraPitch, -80f, 80f);
            PlayerCamera.localEulerAngles = Vector3.right * cameraPitch;
    } 
}
