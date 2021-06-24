using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectMove1 : MonoBehaviour
{
    public Transform[] target;
    public float speed;
    private int current;
    public GameObject Player;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject == Player)
        {
            Vector3 pos = Vector3.MoveTowards(transform.position, target[current].position, speed * Time.fixedDeltaTime);
            GetComponent<Rigidbody>().MovePosition(pos);
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == Player)
        {
            current = (current + 1) % target.Length;
        }

    }

    /*void FixedUpdate()
    {
        if (transform.position != target[current].position)
        {
            Vector3 pos = Vector3.MoveTowards(transform.position, target[current].position, speed * Time.fixedDeltaTime);
            GetComponent<Rigidbody>().MovePosition(pos);
        }

        else current = (current + 1) % target.Length;
    }*/
}
