using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movement : MonoBehaviour
{
    Rigidbody2D rb;
    public float speedX = 100f;
    public float speedY = 10f;
    public bool isGrounded = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        if (h > 0 || h < 0)
        {
            rb.velocity = new Vector2(Time.deltaTime * speedX * h, rb.velocity.y);
            transform.localScale = new Vector3(h, 1f, 1f);

        }

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
        {
            print("space");
            rb.AddForce(Vector2.up * speedY, ForceMode2D.Impulse);

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "win")
        {
            SceneManager.LoadScene("Win State");
        }
    }
}
