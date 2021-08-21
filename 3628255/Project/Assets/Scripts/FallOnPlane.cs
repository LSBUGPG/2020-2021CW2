using UnityEngine;

public class FallOnPlane : MonoBehaviour
{
    public float startHeight;
    private Renderer r;
    private Rigidbody rb;

    private void Start()
    {
        r = GetComponent<Renderer>();
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (r.isVisible)
            return;
        
        transform.rotation = Quaternion.identity;
        transform.position = new Vector3(0, startHeight, 0);
        rb.velocity = new Vector3(0, -7f, 0);
    }
}