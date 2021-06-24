using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(PlayerMotor))]
public class PlayerController : MonoBehaviour

{
    public LayerMask movementMask;
    public string scene;

    Camera cam;
    PlayerMotor motor;
    GrabAndDrag gad;

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        motor = GetComponent<PlayerMotor>();
        gad = GetComponent<GrabAndDrag>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100, movementMask))
            {
                motor.MoveToPoint(hit.point);
            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            gad.OnButtonDown();
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            gad.OnButtonUp();
        }
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Passage"))
        {
            SceneManager.LoadScene(scene);
        }
    }
}
