using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AscendScript : MonoBehaviour
{

    public int upwardsSpeed = 2;

    new    Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update");
        if (Input.GetKey(KeyCode.E))
            rigidbody.AddForce(transform.up * upwardsSpeed);
    }
}
