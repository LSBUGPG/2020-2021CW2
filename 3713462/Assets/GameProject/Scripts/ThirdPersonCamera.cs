using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
    public float CamRotationSpeed = 1;
    public Transform Target, Player;
    public float mouseX, mouseY;

    public Transform Obstruction;
    float zoomSpeed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        //makes it so the cursor isnt visible on screen and locks it the center of the screen
        //Cursor.visible = false;
        //Cursor.lockState = CursorLockMode.Locked;

        Obstruction = Target;
    }
    private void CameraControl()
    {
        //camera rotation on the X and Y axis using the mouse
        mouseX += Input.GetAxis("Mouse X") * CamRotationSpeed;
        mouseY -= Input.GetAxis("Mouse Y") * CamRotationSpeed;
        mouseY = Mathf.Clamp(mouseY, -35, 60);

        //sets the camera to look at the specified target (defined in inspector)
        transform.LookAt(Target);

        //allows both the camera and player to rotate
        Target.rotation = Quaternion.Euler(mouseY, mouseX, 0);
        Player.rotation = Quaternion.Euler(0, mouseX, 0);
    }
    //calls the camera control function
    private void LateUpdate()
    {
        CameraControl();
        viewObstructed();
    }
    //If the camera is colliding with an object (e.g. wall) it zooms in towards the player, and hides/disables the objects mesh renderer but keeps the shadows
    //then reverses it once its not colliding
    private void viewObstructed()
    {
        RaycastHit hit;

        if(Physics.Raycast(transform.position, Target.position - transform.position, out hit, 4.5f))
        {
            if(hit.collider.gameObject.tag != "Player")
            {
                Obstruction = hit.transform;
                Obstruction.gameObject.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;

                if(Vector3.Distance(Obstruction.position, transform.position) >= 3f && Vector3.Distance(transform.position, Target.position) >= 1.5f)
                {
                    transform.Translate(Vector3.forward * zoomSpeed * Time.deltaTime);
                }
            }
            else
            {
                Obstruction.gameObject.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;

                if(Vector3.Distance(transform. position, Target.position) < 4.5f)
                {
                    transform.Translate(Vector3.back * zoomSpeed * Time.deltaTime);
                }
            }
        }
    }
}
