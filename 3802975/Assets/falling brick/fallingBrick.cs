using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallingBrick : MonoBehaviour
{
    Rigidbody2D rb;
    public float breakTime = 2f;
    public float dropTime = 2f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            Invoke("DropPlatform", dropTime);
            Destroy(gameObject, breakTime);
        }
    }

    void DropPlatform()
    {
        rb.isKinematic = false;
    }

}
