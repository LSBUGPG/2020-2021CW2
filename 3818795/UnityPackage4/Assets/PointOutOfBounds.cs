using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointOutOfBounds : MonoBehaviour
{
    public static int Score;
    public int Score2;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        //OutofBounds take away points
        if (other.tag == "Ball")
        {
            Score -= 5;
            Destroy(other.gameObject);
        }
       
    }
}
