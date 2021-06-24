using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{

    public GameObject Door;
    private bool doorIsOpening;

    void Update()
    {
        if (doorIsOpening == true)
        {
            Door.transform.Translate(Vector3.up * Time.deltaTime * 3);
        }

        if(Door.transform.position.y > 3.2f)
        {
            doorIsOpening = false;
        }
    }

    void OnMouseDown()
    {
        doorIsOpening = true;
        
    }

}
