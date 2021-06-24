using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjects : MonoBehaviour
{
    public Transform ObjectHold;
    public RaycastHit HitObject;
    public float distance;
    public Transform Camera;
    public LayerMask RayMask;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Physics.Raycast(Camera.position, Camera.forward, out HitObject, distance, RayMask);
        if(Input.GetKeyDown(KeyCode.E))
		{
            HitObject.collider.GetComponent<GameObject>();
            HitObject.transform.parent = Camera.transform;
            HitObject.transform.position = ObjectHold.position;
            HitObject.collider.GetComponent<Rigidbody>().isKinematic = true;
        }
        else if(Input.GetKeyUp(KeyCode.E))
		{
            HitObject.collider.GetComponent<Rigidbody>().isKinematic = false;
            HitObject.transform.parent = null;
		}
    }
}
