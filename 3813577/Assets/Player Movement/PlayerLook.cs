using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    public Transform player;

    public float MouseSensitivity;

    private float x = 0;
    private float y = 0;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        x += -Input.GetAxis("Mouse Y") * MouseSensitivity;
        y += Input.GetAxis("Mouse X") * MouseSensitivity;

        x = Mathf.Clamp(x, -90, 90);

        transform.localRotation = Quaternion.Euler(x, 0, 0);
        player.transform.localRotation = Quaternion.Euler(0, y, 0);

        if(Input.GetKeyDown(KeyCode.Escape))
		{
            if(Cursor.lockState == CursorLockMode.Locked)
			{
                Cursor.lockState = CursorLockMode.None;
			}
            if(Cursor.lockState== CursorLockMode.None)
			{
                Cursor.lockState = CursorLockMode.Locked;
			}
		}
    }
}
//this game makes use of the Player Movement Script by vvixel
//https://github.com/vvixell/3d-rigidbody-fps-controller/tree/main
