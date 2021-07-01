using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script01 : MonoBehaviour
{
    public int count = 0;
    public GameObject ball;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Count starting value is: " + count);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            
            Instantiate(ball, transform.position, Quaternion.identity);

        }

    }
}