using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public Transform theDest;

    void OnMouseDown()
    {
        GetComponent<BoxCollider>().enabled = false;
        //turns off gravity
        GetComponent<Rigidbody>().useGravity = false;
        //moving the position to the destination
        this.transform.position = theDest.position;
        this.transform.parent = GameObject.Find("Destination").transform;
    }

     void OnMouseUp()
    {
        this.transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;
        GetComponent<BoxCollider>().enabled = true;
    }
}
