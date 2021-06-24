using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class HomingMissile : MonoBehaviour
{
    public Transform target;    

    public float speed = 6;
    public float rotateSpeed = 400f;

    

    private Rigidbody2D rb;
    public HealthScript health;


    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
       // target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = (Vector2) target.position - rb.position;

        direction.Normalize();

        float rotateAmount = Vector3.Cross(direction, transform.up).z;

        rb.angularVelocity = - rotateAmount * rotateSpeed;

        rb.velocity = transform.up * speed;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            health.TakeDamage(1);
            Destroy(gameObject);
        }
        


    }
}
