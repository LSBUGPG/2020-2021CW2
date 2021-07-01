using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class End : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {

        if (ScoringSystem.theScore == 21)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
            Cursor.lockState = CursorLockMode.None;


        }


    }
}
