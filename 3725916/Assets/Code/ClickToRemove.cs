using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToRemove : MonoBehaviour
{
    Ray ray;

    RaycastHit hit;

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, float.MaxValue))
            {
                if (hit.rigidbody)
                {
                    hit.rigidbody.gameObject.SetActive(false);
                }
            }
        }
    }
}
