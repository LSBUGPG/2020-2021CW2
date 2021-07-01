using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
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
        if(other.tag == "Ball")
        {
            Score += 5;
            Score2 += 5;
            
            Destroy(other.gameObject);
        }
        /*else if(other.tag == "10point")
        {
            Score += 10;
            Destroy(gameObject);

        }

        else if(other.tag == "OutOfBounds")
        {
            Score -= 5;
            Destroy(gameObject);
        }*/
    }
}
