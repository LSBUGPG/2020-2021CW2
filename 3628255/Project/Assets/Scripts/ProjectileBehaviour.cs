using UnityEngine;

public class ProjectileBehaviour : MonoBehaviour
{
    public float speed;
    private Renderer r;
    private Rigidbody rb;
    
    private void Start()
    {
        r = GetComponent<Renderer>();
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * speed;
    }

    private void Update()
    {
        if (r.isVisible)
            return;
        
        Destroy(gameObject);
    }
}