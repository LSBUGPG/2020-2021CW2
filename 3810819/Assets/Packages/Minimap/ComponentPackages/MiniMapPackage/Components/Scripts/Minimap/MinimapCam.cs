using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinimapCam : MonoBehaviour
{
    //public bool miniCamCanRotate = false;

    public GameObject miniCam;
    
    public Transform player;

    MinimapCamRotation miniCamRotation;
    void Awake()
    {
        miniCamRotation = GetComponent<MinimapCamRotation>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 newPosition = player.position;
        newPosition.y = transform.position.y;
        transform.position = newPosition;

        if(miniCamRotation.miniCamCanRotate == true)
        {
            miniCamRotation.MinimapRotation();
        }
        else
        {
            miniCamRotation.ReturnRotation();
        }
    }

    /*public void MinimapRotation()
    {
        transform.rotation = Quaternion.Euler(90f, player.eulerAngles.y, 0f);
    }

    public void ReturnRotation()
    {
        transform.rotation = Quaternion.Euler(90f, 0f, 0f);
    }*/
}
