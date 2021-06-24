using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillThePlayer : MonoBehaviour
{

    Rigidbody rigidbody;
    public int LoadNextLevel;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            Application.LoadLevel(LoadNextLevel);
            
        }
    }
}
