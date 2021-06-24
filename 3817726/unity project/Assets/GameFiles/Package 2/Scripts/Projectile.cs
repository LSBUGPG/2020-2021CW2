using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    int damage = (int)10f;

    [SerializeField]
    private float speed;

    public Vector3 Direction { get; set; }

    void Update()
    {
        transform.Translate(Direction * speed * Time.deltaTime, Space.World);  
    }
   


    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
