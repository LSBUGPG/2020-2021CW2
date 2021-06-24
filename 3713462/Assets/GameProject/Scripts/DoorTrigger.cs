using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public GameObject door;

    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Box")
        {
            door.transform.position = new Vector3(0, 4, 0);
        }

    }
}
