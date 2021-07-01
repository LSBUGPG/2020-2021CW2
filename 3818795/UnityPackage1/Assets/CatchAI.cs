using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CatchAI : MonoBehaviour
{
    public int Score = 0;
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
        if(other.tag == ("AI"))
        {
            Score++;
            Debug.Log("MyTag");
        }
    }
}
