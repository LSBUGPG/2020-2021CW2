using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor_Shape : MonoBehaviour
{
    public Camera camera;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                Corner2 corner = hit.transform.GetComponent<Corner2>();
                corner.Highlight();
            }
        }
        
    }
}
