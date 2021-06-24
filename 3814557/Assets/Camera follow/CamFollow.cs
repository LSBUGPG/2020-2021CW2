using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{

    public Transform target;
    public float speed = 5f;

    float startZ;

    // Start is called before the first frame update
    void Start()
    {
        startZ = transform.position.z;
        speed /= 100;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, target.position, speed); 
        transform.position = new Vector3(transform.position.x, transform.position.y, startZ);
    }
}
