using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartscript : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Finish"))
        {
            SceneManager.LoadScene("SampleScene");
        }
        if (other.gameObject.CompareTag("Respawn"))
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
   
}
