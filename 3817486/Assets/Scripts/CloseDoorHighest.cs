﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseDoorHighest : MonoBehaviour
{
    public GameObject Door;
    private bool doorIsClosing;

    private void Update()
    {
        if (doorIsClosing == true)
        {
            Door.transform.Translate(Vector3.down * Time.deltaTime * 3);
        }

        if (Door.transform.position.y < 8.9f)
        {
            doorIsClosing = false;
        }



    }
    void OnMouseDown()
    {
        doorIsClosing = true;
    }
}
