using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinimapCamRotation : MonoBehaviour
{
    public bool miniCamCanRotate = false;

    MinimapCam playerPos;

    void Awake()
    {
        playerPos = GetComponent<MinimapCam>();
    }
    public void MinimapRotation()
    {
        transform.rotation = Quaternion.Euler(90f, playerPos.player.eulerAngles.y, 0f);
    }

    public void ReturnRotation()
    {
        transform.rotation = Quaternion.Euler(90f, 0f, 0f);
    }

}
