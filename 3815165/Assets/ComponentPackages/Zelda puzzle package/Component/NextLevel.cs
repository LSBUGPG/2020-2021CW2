using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevel : MonoBehaviour
{
    public int loadNextLevel;

    public void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.tag == "Player") 
        {
            Application.LoadLevel (loadNextLevel);
           
            
        }
    }
}
