using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : Ammunition
{
    public Rigidbody bullet;
    private Vector3 target;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();            
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Reload();
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            CollectAmmunition();
        }
    }

    public override void Shoot()
    {
        base.Shoot();
        RaycastHit hit;
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (!noAmmo)
        {
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                target = hit.point;

                Vector3 direction = target - transform.position;

                Rigidbody clone;
                clone = Instantiate(bullet, transform.position, Quaternion.identity);
                clone.velocity = direction * 10;
            }
        }
    }

}
