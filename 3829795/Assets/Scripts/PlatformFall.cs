using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformFall : MonoBehaviour
{

    bool isRising = false;
    float downSpeed = 0;

    Vector3 startPosition;
    public float resetTime = 3;

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        rb = GetComponent<Rigidbody>();
    }

    void OnTriggerEnter (Collider collider)
    {
        if (collider.gameObject.name == "Player")        
        {
            isRising = false;
            rb.useGravity = true;
            rb.isKinematic = false;
            rb.constraints = RigidbodyConstraints.FreezeRotation;
            Invoke("resetPosition", resetTime);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isRising)
        {
            if (transform.position.y < startPosition.y)
            {
                downSpeed += Time.deltaTime / 35;
                transform.position = new Vector3(transform.position.x, transform.position.y + downSpeed, transform.position.z);
            }
            else
            {
                transform.position = startPosition;
            }
        }
    }
    void resetPosition()
    {
        rb.useGravity = false;
        isRising = true;
        rb.isKinematic = true;
    }
}
