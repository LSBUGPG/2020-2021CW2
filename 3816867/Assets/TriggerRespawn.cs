using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;


public class TriggerRespawn : MonoBehaviour
{
    public Scene loadedlevel;
    // Start is called before the first frame update
    void Start()
    {
        loadedlevel = SceneManager.GetActiveScene();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(loadedlevel.name);
        }
    }
}

