using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartNextLevel : MonoBehaviour
{
    private bool playerpressedbutton;

    private void Update()
    {
        if(playerpressedbutton == true)
        {
            StartCoroutine("LoadScene2");
        }
    }


    private void OnMouseDown()
    {
        playerpressedbutton = true;
    }

    IEnumerator LoadScene2()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(1);
    }
}
