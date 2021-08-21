using System;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    public GameObject projectile;
    public Transform spawnPoint;
    public float recoilForce;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var p = transform.position;
            Instantiate(projectile, spawnPoint.position, transform.rotation);

            if (recoilForce > 0)
                rb.AddForce(-transform.forward * recoilForce, ForceMode.Impulse);
        }
    }
}