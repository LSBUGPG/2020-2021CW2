using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectMove : MonoBehaviour
{
    public Transform[] target;
    public float speed;
    private int direction = 1;
    private int current;

    void FixedUpdate()
    {
            transform.Translate(Vector3.forward*speed*Time.fixedDeltaTime*direction);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform == target[0] || other.transform == target[1])
        {
            direction *= -1;
        }
    }
}
