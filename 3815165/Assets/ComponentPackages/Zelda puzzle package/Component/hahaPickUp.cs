using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hahaPickUp : MonoBehaviour
{

    public Rigidbody rb;
    public BoxCollider col;
    public Transform player, container, cam;

    public float pickUpRange;
    public float dropForwardForce, dropUpwardForce;
    public bool equipped;
    public static bool slotFull;


    // Start is called before the first frame update
    private void Start()
    {
        equipped = false;
        slotFull = false;

        if (!equipped)
        {
            rb.isKinematic = false;
            col.isTrigger = false;
        }

        if (equipped)
        {
            rb.isKinematic = true;
            col.isTrigger = true;
            slotFull = true;

        }
    }

    // Update is called once per frame
    private void Update()
    {
        Vector3 distanceToPlayer = player.position - transform.position;
        if (!equipped && distanceToPlayer.magnitude <= pickUpRange && Input.GetKeyDown(KeyCode.E) && !slotFull) PickUp();
        
        if(equipped && Input.GetKeyDown(KeyCode.Q)) Drop();
    }

    private void PickUp()
    {
        equipped = true;
        slotFull = true;

        transform.SetParent(container);
        transform.localPosition = Vector3.zero;
        transform.localRotation = Quaternion.Euler(Vector3.zero);
        transform.localScale = Vector3.one;


        rb.isKinematic = true;

        col.isTrigger = true;

    }

    private void Drop()
    {
        equipped = false;
        slotFull = false;

        transform.SetParent(null);


        rb.isKinematic = false;

        col.isTrigger = false;

        rb.velocity = player.GetComponent<Rigidbody>().velocity;

        rb.AddForce(cam.forward * dropForwardForce, ForceMode.Impulse);
        rb.AddForce(cam.up * dropUpwardForce, ForceMode.Impulse);

        float random = Random.Range(-1f, 1f);
        rb.AddTorque(new Vector3(random, random, random) * 10);
    }
}
