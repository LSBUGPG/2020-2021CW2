using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabAndDrag : MonoBehaviour
{
    public GameObject tempParent;
    public Transform guide;

    private Vector3 originalPos;
    private bool touchingPickable = false;
    private GameObject pickableItem;
    private Pickable pickable;

    public void OnButtonDown()
    {
        if (touchingPickable)
        {
            pickableItem.GetComponent<Rigidbody>().useGravity = false;
            pickableItem.GetComponent<Rigidbody>().isKinematic = true;
            originalPos = pickableItem.transform.position;
            pickableItem.transform.position = guide.transform.position;
            pickableItem.transform.rotation = guide.transform.rotation;
            pickableItem.transform.parent = tempParent.transform;
        }
    }

    public void OnButtonUp()
    {
        if (touchingPickable)
        {
            pickableItem.GetComponent<Rigidbody>().useGravity = true;
            pickableItem.GetComponent<Rigidbody>().isKinematic = false;
            pickableItem.transform.parent = null;
            if (originalPos != Vector3.zero)
            {
                pickableItem.transform.position = originalPos;
            }
            originalPos = Vector3.zero;
            pickable.DoIt();
        }
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pickable"))
        {
            if (touchingPickable == false)
            {
                touchingPickable = true;
                pickableItem = other.gameObject;
                pickable = pickableItem.GetComponent<Pickable>();
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Pickable"))
        {
            if (pickableItem == other.gameObject)
            {
                touchingPickable = false;
                pickableItem = null;
                pickable = null;
            }
        }
    }
}
