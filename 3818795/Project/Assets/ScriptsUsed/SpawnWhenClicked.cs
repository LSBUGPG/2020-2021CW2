using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWhenClicked : MonoBehaviour
{
    public GameObject Ball;
    void Update()
    {
        //  Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0f);
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 10.0f;
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 wordPos;
            Ray ray = Camera.main.ScreenPointToRay(mousePos);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 1000f))
            {
                wordPos = hit.point;
            }
            else
            {
                wordPos = Camera.main.ScreenToWorldPoint(mousePos);
            }
            Instantiate(Ball, wordPos, Quaternion.identity);
            
        }
    }

   
}
