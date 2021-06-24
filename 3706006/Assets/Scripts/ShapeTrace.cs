using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeTrace : MonoBehaviour
{
    public List<GameObject> corners;
    GameObject currentCorner;
    LineRenderer line;
    
    int cornerCount = 0;
    bool lastCorner;
    bool mouseIsDown = false;
    bool end = false;

    public float distance;
    public int numberOfCorners;



    // Start is called before the first frame update
    void Start()
    {
        corners = new List<GameObject>();
        line = GetComponent<LineRenderer>();

        lastCorner = false;
    }

    // Update is called once per frame
    void Update()
    {
        line.startWidth = 0.01f;
        line.endWidth = 0.01f;
        line.alignment = LineAlignment.TransformZ;
        line.positionCount = 1;

        line.positionCount = corners.Count;
        for (int i = 0; i < corners.Count; i++)
        {
            line.SetPosition(i, corners[i].transform.position);
        }
        if (Input.GetMouseButton(0))
        {
            mouseIsDown = true;
        }
        else
        {
            mouseIsDown = false;
            foreach (var item in corners)
            {
                item.GetComponent<Corner>().EnableCorner();
                print("Enabled corners");
            }
            if (corners.Count < numberOfCorners)
            {
                corners = new List<GameObject>();
                lastCorner = false;
            }
        }
        if (!mouseIsDown)
        {
            if (corners.Count < numberOfCorners)
            {
                LineRenderer bc = GetComponent<LineRenderer>();
                bc.positionCount = 0;
            }

            return;
        }
        LineRenderer cc = GetComponent<LineRenderer>();
        cc.startWidth = 10f;
        cc.endWidth = 10f;
        cc.alignment = LineAlignment.TransformZ;
        cc.positionCount = 1;
        if (corners.Count > 0)
        {
            cc.positionCount = corners.Count;
            for (int i = 0; i < corners.Count; i++)
            {
                cc.SetPosition(i, corners[i].transform.position);
            }
            if (cc.positionCount < numberOfCorners+1)
            {
                //GameObject obj = Instantiate(corners[0], corners[0].transform.position, Quaternion.identity) as GameObject;
                //obj.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
                //print(corners[0].transform.localScale);
                lastCorner = true;
            }
        }
    }

    public void OverCorner(GameObject c)
    {
        corners.Add(c);
        currentCorner = c;
        cornerCount += 1;
        c.GetComponent<Corner>().DisableCorner();
    }
}
